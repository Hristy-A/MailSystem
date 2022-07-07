using MailSystem.Domain.Interfaces;
using MailSystem.Infrastructure.Mailing;

namespace MailSystem.AppSetup.ConfigureServices
{
    internal static class ConfigureServiceMailProvider
    {
        internal static void Configure(WebApplicationBuilder builder)
        {
            builder.Services.AddSingleton<IMailProvider, SMTPMailProvider>();
        }
    }
}
