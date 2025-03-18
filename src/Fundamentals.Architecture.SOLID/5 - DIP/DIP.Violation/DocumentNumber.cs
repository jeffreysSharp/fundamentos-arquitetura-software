namespace Fundamentals.Architecture.SOLID.DIP.DIP.Violation
{
    public class DocumentNumber
    {
        public string  Number { get; set; }

        public bool Validate()
        {
            return Number.Length == 11;
        }
    }
}
