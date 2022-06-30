using System.Text;

namespace MailSystem
{
    internal static class ConnectionStringProvider
    {
        internal static string GetConnectionStringForEnvironmentVariablis()
        {
            StringBuilder sb = new();

            sb
                .Add("Server=")
                .Add(Environment.GetEnvironmentVariable("DB_HOST") ?? "Undefined")
                .Add(";");

            sb
                .Add("Database=")
                .Add(Environment.GetEnvironmentVariable("DATABASE_NAME") ?? "Unnamed")
                .Add(";");

            sb
                .Add("Trusted_Connection=")
                .Add(Environment.GetEnvironmentVariable("TRUSTED_CONNECTION") ?? "False")
                .Add(";");

            return sb.ToString();
        }

        private static StringBuilder Add(this StringBuilder sb, string text)
        {
            sb.Append(text);
            return sb;
        }
    }
}
