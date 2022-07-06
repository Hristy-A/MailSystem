using MailSystem.Domain.Core;
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

        public MailSystemController(ILogger<MailSystemController> logger, MailSystemContext db)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _db = db ?? throw new ArgumentNullException(nameof(db));

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

            _db.Emails.Add(email);
            _db.SaveChanges();
            return Ok(email);
        }
    }
}