using System;
using CSharpFunctionalExtensions;
using RailwayDemo.Dto;
using RailwayDemo.NonDomain;

namespace RailwayDemo.Domain
{
    public class CustomerRegistrationService
    {
        private readonly ICustomerRepository _repository;
        private readonly IGateway _gateway;

        public CustomerRegistrationService(ICustomerRepository repository, IGateway gateway)
        {
            _repository = repository;
            _gateway = gateway;
        }

        public CustomerCreatedResponse RegisterCustomer(CreateCustomerRequest createCustomerRequest)
        {
            return SecondIteration(createCustomerRequest);
        }

        private CustomerCreatedResponse FirstIteration(CreateCustomerRequest createCustomerRequest)
        {
            CustomerCreatedResponse registerCustomer = new CustomerCreatedResponse();
            if (!IsValid(createCustomerRequest))
            {
                registerCustomer.WasSuccessful = false;
            }
            var customer = new Customer {Name = createCustomerRequest.Name};
            _repository.Save(customer);
            registerCustomer.CustomerId = 42;
            return registerCustomer;
        }

        private CustomerCreatedResponse SecondIteration(CreateCustomerRequest createCustomerRequest)
        {
            return ValidateAndMap(createCustomerRequest)
                .OnSuccess(x => _repository.Save(x))
                .OnBoth(x => x.IsSuccess
                    ? new CustomerCreatedResponse{ CustomerId = x.Value.Id }
                    : new CustomerCreatedResponse{ WasSuccessful = false }
                );
        }

        private Result<Customer> ValidateAndMap(CreateCustomerRequest createCustomerRequest)
        {
            if (!IsValid(createCustomerRequest))
            {
                return Result.Fail<Customer>("Customer is not valid");
            }
            var customer = new Customer { Name = createCustomerRequest.Name };
            return Result.Ok(customer);
        }


        private static bool IsValid(CreateCustomerRequest createCustomerRequest)
        {
            return !String.IsNullOrWhiteSpace(createCustomerRequest.Name);
        }
    }
}