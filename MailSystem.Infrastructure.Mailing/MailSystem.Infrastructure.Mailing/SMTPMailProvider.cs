using MailKit.Net.Smtp;
using MailSystem.Domain.Core;
using MailSystem.Domain.Interfaces;
using MimeKit;

namespace MailSystem.Infrastructure.Mailing
{
    public class SMTPMailProvider : IMailProvider
    {
        public void Send(Email email, string server, int port, string username, string password)
        {
            MimeMessage message = new();

            message.From.Add(new MailboxAddress(null, email.From));
            message.To.Add(new MailboxAddress(null, email.Title));
            message.Cc.Add(new MailboxAddress(null, email.Cc));
            message.Subject = email.Title;

            message.Body = email.IsHtml 
                ? new TextPart("html") { Text = email.Body } 
                : new TextPart("plain") { Text = email.Body };

            using SmtpClient client = new();

            client.Connect(server, port, false);
            client.Authenticate(username, password);
            client.Send(message);
            client.Disconnect(true);
        }

        public IEnumerable<Email> GetAll(string server, int port, string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}