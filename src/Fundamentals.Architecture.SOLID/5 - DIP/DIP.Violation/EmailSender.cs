namespace Fundamentals.Architecture.SOLID.DIP.DIP.Violation
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
