namespace RailwayDemoCore.Dto
{
    public class CustomerCreatedResponse
    {
        public bool WasSuccessful { get; set; } = true;

        public bool Failed => !WasSuccessful;

        public string ErrorMessage { get; set; }

        public int? CustomerId { get; set; }
    }
}