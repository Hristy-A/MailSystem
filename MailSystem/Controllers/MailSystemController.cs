using MailSystem.Domain.Core;
using MailSystem.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace MailSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MailSystemController : ControllerBase
    {
        private readonly ILogger<MailSystemController> _logger;

        public MailSystemController(ILogger<MailSystemController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAccounts")]
        public IEnumerable<Account> Get()
        {
            return Enumerable.Empty<Account>();
        }
    }
}