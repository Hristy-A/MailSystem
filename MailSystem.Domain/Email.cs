namespace MailSystem.Domain.Core
{
    public class Email
    {
        public Guid Id { get; set; }
        public string To { get; set; } = null!;
        public string From { get; set; } = null!;
        public string Cc { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? Body { get; set; }
        public bool IsHtml { get; set; }
    }
}
