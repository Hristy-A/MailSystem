using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSystem.Domain.Interfaces;
using MailSystem.Infrastructure.Mailing;

namespace MailSystem.AppSetup.ConfigureServices
{
    internal static class ConfigureServiceMailProvider
    {
        internal static void Configure(WebApplicationBuilder builder)
        {
            builder.Services.AddSingleton<IMailProvider, MailProvider>();
        }
    }
}
