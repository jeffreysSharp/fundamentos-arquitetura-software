namespace Fundamentals.Architecture.DI.Models
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
