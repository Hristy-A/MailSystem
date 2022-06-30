namespace MailSystem.Domain.Core
{
    public class Account
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public DateTimeOffset CreatedAt { get; set; }
        public string NickName { get; set; } = null!;
        public bool IsBlocked { get; set; }
        public string? ReasonOfBlocking { get; set; }
    }
}