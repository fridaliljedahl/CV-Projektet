using MessageWebAPI.Data;
using MessageWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessageWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiverController : ControllerBase
    {
        private ApplicationDbContext context;
        public ReceiverController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("{Id}")]
        public List<Message> GetReceiver(string Id)
        {
            var messages = context.Messages.Where(m => m.UserReceiver.Id == Id);
            return messages.ToList();
        }

    }
}
