using CvWebApi.Data;
using CvWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CvWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {

        private ApplicationDbContext _applicationDbContext;

        public MessageController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext= applicationDbContext;
        }

        [HttpGet]
        public List<Message> Get()
        {
            return _applicationDbContext.Messages.ToList();
        }

    }
}
