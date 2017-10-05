using CSharpFunctionalExtensions;
using RailwayDemo.Domain;

namespace RailwayDemo.NonDomain
{
    public interface ICustomerRepository
    {
        Result<Customer> Save(Customer customer);
    }
}