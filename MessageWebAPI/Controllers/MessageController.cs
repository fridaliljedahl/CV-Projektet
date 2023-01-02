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
        public List<Message> GetMessages()
        {
            var messages = context.Messages;
            return messages.ToList();
        }

        [HttpPut]
        public void SetReadState(int messageId)
        {
            Message msg = context.Messages.Find(messageId);
            msg.Read = !msg.Read;
            context.Messages.Update(msg);
            context.SaveChanges();
        }

        [HttpPost]
        public void SendMessage(Message msg)
        {
            if (ModelState.IsValid)
            {
                context.Messages.Add(msg);
            }
            //else
            //{
            //    return false;
            //}
        }

    }
}
