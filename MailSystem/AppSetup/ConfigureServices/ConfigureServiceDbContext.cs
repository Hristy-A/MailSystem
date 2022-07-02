using MailSystem.Infrastructure.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace MailSystem.AppSetup.ConfigureServices
{
    public static class ConfigureServiceDbContext
    {
        public static void Configure(WebApplicationBuilder builder)
        {
            var services = builder.Services;
            var configuration = builder.Configuration;

            services.AddDbContext<MailSystemContext>(options =>
                options.UseSqlServer(new SqlConnection(
                    new SqlConnectionStringBuilder
                    {
                        DataSource = $"{configuration["DB_HOST"]},{configuration["DB_PORT"]}",
                        InitialCatalog = configuration["DATABASE_NAME"],
                        UserID = configuration["DB_USERNAME"],
                        Password = configuration["DB_PASS"]
                    }.ToString())
                ));
        }
    }
}
