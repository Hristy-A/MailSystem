using System.ComponentModel.DataAnnotations;
using MailSystem.Domain.Core;

namespace MailSystem.Domain.Interfaces
{
    public interface IMailProvider
    {
        void Send(Email email, string server, string username, string password);
        IEnumerable<Email> GetAll(string server, string username, string password);
    }
}