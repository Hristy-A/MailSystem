namespace MailSystem.Domain.Core
{
    public class Email
    {
        public ulong Id { get; set; }
        public string To { get; set; } = default!;
        public string From { get; set; } = default!;
        public string Cc { get; set; } = default!;
        public string Title { get; set; } = default!;
        public string? Body { get; set; }
        public bool IsHtml { get; set; }
    }
}
