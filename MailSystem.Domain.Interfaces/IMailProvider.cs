using MailSystem.Domain.Core;

namespace MailSystem.Domain.Interfaces
{
    public interface IMailProvider
    {
        void Send(Email email, string server, int port, string username, string password);
        IEnumerable<Email> GetAll(string server, int port, string username, string password);
    }
}