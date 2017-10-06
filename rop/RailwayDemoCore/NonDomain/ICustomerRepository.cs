using CSharpFunctionalExtensions;
using RailwayDemoCore.Domain;

namespace RailwayDemoCore.NonDomain
{
    public interface ICustomerRepository
    {
        Result<Customer> Save(Customer customer);
    }
}