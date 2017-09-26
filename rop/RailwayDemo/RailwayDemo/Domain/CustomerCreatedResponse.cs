namespace RailwayDemo.Domain
{
    public class CustomerCreatedResponse
    {
        public bool IsSuccess { get; set; } = true;

        public bool IsFailure => !IsSuccess;

        public string ErrorMessage { get; set; }

        public Customer Customer { get; set; }
    }
}