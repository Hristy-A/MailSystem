namespace MailSystem.AppSetup.ConfigureServices
{
    internal static class ConfigureDefaultServices
    {
        internal static void Configure(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
        }
    }
}