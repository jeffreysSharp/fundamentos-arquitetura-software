namespace Fundamentals.Architecture.SOLID.DIP.DIP.Solution
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Email EmailAddress { get; set; }
        public DocumentNumber DocumentNumber { get; set; }
        public DateTime CreatedAt { get; set; }

        public bool Validate()
        {
            return EmailAddress.Validate() && DocumentNumber.Validate();
        }
    }
}
