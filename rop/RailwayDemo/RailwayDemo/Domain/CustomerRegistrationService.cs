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
    }
}