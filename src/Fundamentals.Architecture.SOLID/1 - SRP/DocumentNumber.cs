namespace Fundamentals.Architecture.SOLID.SRP
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
