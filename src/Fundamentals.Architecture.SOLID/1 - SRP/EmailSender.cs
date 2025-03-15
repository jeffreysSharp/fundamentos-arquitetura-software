namespace Fundamentals.Architecture.SOLID.SRP
{
    public class EmailSender
    {
        public void SendEmail(string recipient, string subject, string body)
        {            
            string formattedBody = FormatBody(body);            
        }

        private string FormatBody(string body)
        {
            return "<html><body>" + body + "</body></html>";
        }
    }
}
