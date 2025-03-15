namespace Fundamentals.Architecture.SOLID.SRP
{
    public class Email
    {
        public string Address { get; set; }

        public bool Validate()
        {
            return Address.Contains("@");
        }
    }
}
