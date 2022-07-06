using MailSystem.Domain.Core;
using MailSystem.Domain.Interfaces;
using MailSystem.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MailSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MailSystemController : ControllerBase
    {
        private readonly ILogger<MailSystemController> _logger;
        private readonly MailSystemContext _db;
        private readonly IMailProvider _mailProvider;

        public MailSystemController(ILogger<MailSystemController> logger, 
            MailSystemContext db, IMailProvider mailProvider)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _db = db ?? throw new ArgumentNullException(nameof(db));
            _mailProvider = mailProvider ?? throw new ArgumentNullException(nameof(mailProvider));

            _db.Database.Migrate();
        }

        [HttpGet]
        public IEnumerable<Email> AccountGet()
        {
            return _db.Emails.ToArray();
        }

        [HttpPost]
        public ActionResult<Email> SendPost(Email email)
        {
            _ = email ?? throw new ArgumentNullException(nameof(email));

            try
            {
                _mailProvider.Send(email, "smtps://smtp.gmail.com", 465, "user", "pass");
            }
            catch (Exception e)
            {
                _logger.Log(LogLevel.Error, e.Message);
                return StatusCode(500);
            }

            _db.Emails.Add(email);
            _db.SaveChanges();
            return Ok(email);
        }
    }
}