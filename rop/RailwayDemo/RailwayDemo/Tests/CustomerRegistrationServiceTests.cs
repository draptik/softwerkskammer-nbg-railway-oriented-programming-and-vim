using NSubstitute;
using RailwayDemo.Domain;
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
            _gateway = Substitute.For<IGateway>();

            _sut = new CustomerRegistrationService(_customerRepository, _gateway);
        }

        [Fact]
        public void Creating_a_customer_returns_a_response()
        {
            
        }

        [Fact]
        public void Creating_a_customer_returns_a_successful_response_if_request_is_valid()
        {
            
        }

        [Fact]
        public void Creating_a_customer_returns_a_failure_response_if_request_is_invalid()
        {
            
        }
    }
}