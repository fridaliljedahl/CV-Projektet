using MessageWebAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MessageWebAPI.Models;

namespace MessageWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private ApplicationDbContext context;
        public MessageController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public List<Message> Get()
        {
            return context.Messages.ToList();
        }



    }
}
