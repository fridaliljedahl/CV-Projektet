using MessageWebAPI.Data;
using MessageWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessageWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SenderController : ControllerBase
    {
        private ApplicationDbContext context;
        public SenderController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpGet("{Id}")]
        public List<Message> GetSender(string Id)
        {
            var messages = context.Messages.Where(m => m.UserSender.Id == Id);
            return messages.ToList();
        }
    }
}
