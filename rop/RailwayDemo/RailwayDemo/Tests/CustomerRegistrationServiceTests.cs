using CSharpFunctionalExtensions;
using FluentAssertions;
using NSubstitute;
using RailwayDemo.Domain;
using RailwayDemo.Dto;
using RailwayDemo.NonDomain;
using Xunit;

namespace RailwayDemo.Tests
{
    public class CustomerRegistrationServiceTests
    {
        private readonly CustomerRegistrationService _sut;
        private readonly ICustomerRepository _customerRepository;
        private readonly IGateway _gateway;

        public CustomerRegistrationServiceTests()
        {
            _customerRepository = Substitute.For<ICustomerRepository>();
            _customerRepository.Save(Arg.Any<Customer>()).Returns(Result.Ok(new Customer()));
            _gateway = Substitute.For<IGateway>();
            _sut = new CustomerRegistrationService(_customerRepository, _gateway);
        }

        [Fact]
        public void Creating_a_customer_returns_a_response()
        {
            var response = _sut.RegisterCustomer(new CreateCustomerRequest());
            response.Should().NotBeNull();
        }

        [Fact]
        public void Creating_a_customer_returns_a_successful_response_if_request_is_valid()
        {
            var request = new CreateCustomerRequest();
            request.Name = "test";
            var response = _sut.RegisterCustomer(request);
            response.WasSuccessful.Should().BeTrue();
        }

        [Fact]
        public void Creating_a_customer_returns_a_failure_response_if_request_is_invalid()
        {
            var request = new CreateCustomerRequest();
            request.Name = "";
            var response = _sut.RegisterCustomer(request);
            response.WasSuccessful.Should().BeFalse();
            
        }

        [Fact]
        public void Creating_a_customer_should_call_repository_save()
        {            
            var request = new CreateCustomerRequest();
            request.Name = "testblah";
            var response = _sut.RegisterCustomer(request);
            _customerRepository.Received().Save(Arg.Any<Customer>());

        }
    }
}