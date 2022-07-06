using MailSystem.Infrastructure.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace MailSystem.AppSetup.ConfigureServices
{
    internal static class ConfigureServiceDbContext
    {
        internal static void Configure(WebApplicationBuilder builder)
        {
            var services = builder.Services;
            var configuration = builder.Configuration;

            string connectionString = new SqlConnectionStringBuilder
            {
                DataSource = $"{configuration["DB_HOST"]},{configuration["DB_PORT"]}",
                InitialCatalog = configuration["DATABASE_NAME"],
                UserID = configuration["DB_USERNAME"],
                Password = configuration["DB_PASS"]
            }.ToString();

            services.AddDbContext<MailSystemContext>(options =>
                options.UseSqlServer(connectionString));
        }
    }
}
