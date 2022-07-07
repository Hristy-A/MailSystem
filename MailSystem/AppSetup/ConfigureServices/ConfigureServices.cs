namespace MailSystem.AppSetup.ConfigureServices
{
    internal static class ConfigureServices
    {
        internal static void Configure(WebApplicationBuilder builder)
        {
            ConfigureServiceDbContext.Configure(builder);
            ConfigureServiceMailProvider.Configure(builder);

            ConfigureDefaultServices.Configure(builder);
        }
    }


}
