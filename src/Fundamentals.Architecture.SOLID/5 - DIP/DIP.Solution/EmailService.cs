using Fundamentals.Architecture.SOLID.DIP.DIP.Solution.Interfaces;
using System.Net.Mail;

namespace Fundamentals.Architecture.SOLID.DIP.DIP.Solution
{
    public class EmailService : IEmailService
    {
        public void Send(string from, string to, string subjet, string message)
        {
            var mail = new MailMessage(from, to);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = subjet;
            mail.Body = message;
            client.Send(mail);
        }
    }
}
