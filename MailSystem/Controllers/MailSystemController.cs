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
            _logger = logger;
            _db = db;
            _db.Database.Migrate();
        }

        [HttpGet(Name = "GetAccounts")]
        public IEnumerable<Account> Get()
        {
            _db.SaveChanges();
            return Enumerable.Empty<Account>();
        }
    }
}