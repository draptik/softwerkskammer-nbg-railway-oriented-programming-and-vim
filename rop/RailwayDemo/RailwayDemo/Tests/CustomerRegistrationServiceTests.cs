using RailwayDemo.Domain;
using Xunit;

namespace RailwayDemo.Tests
{
    public class CustomerRegistrationServiceTests
    {
        private readonly CustomerRegistrationService _sut;

        public CustomerRegistrationServiceTests()
        {
            _sut = new CustomerRegistrationService();
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