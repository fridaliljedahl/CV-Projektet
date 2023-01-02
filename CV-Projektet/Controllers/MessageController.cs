using CV_Projektet.Data;
using CV_Projektet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CV_Projektet.Controllers
{
    public class MessageController : Controller
    {
        private UserManager<User> userManager;
        private SignInManager<User> signInManager;
        private HttpClient client;
        private ApplicationDbContext context;

        public MessageController(UserManager<User> userManager, SignInManager<User> signInManager, HttpClient client, ApplicationDbContext context)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.client = client;
            this.context = context;
        }

        public async Task<IActionResult> MyMessages()
        {
            string route = client.BaseAddress + "receiver/" + userManager.GetUserId(User);
            HttpResponseMessage response = await client.GetAsync(route);
            string data = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            List<Message>? messages = JsonSerializer.Deserialize<List<Message>>(data, options)
                .OrderBy(m => m.Date).ToList();
            return View(messages);
        }

        [HttpGet]
        public IActionResult SendMessage(SendMessageViewModel view)
        {
            var newView = TempData["view"];
            return View(view);
        }

        //public IActionResult SendMessage(SendMessageViewModel view)
        //{
        //    //if (view.MethodCaller.Equals("Initial"))
        //    //{
        //        //view.MethodCaller = "Here";
        //        return View(view);
        //    //}
        //    //else
        //    //{
        //    //    //view.MethodCaller = "Here";
        //    //    view.MessageSentMessage = "Ditt meddelande är skickat!";
        //    //    return View(view);
        //    //}
        //}


        //public IActionResult SetReadState(int messageId)
        //{
        //    Message msg = context.Messages.Find(messageId);
        //    msg.Read = !msg.Read;
        //    context.Messages.Update(msg);
        //    context.SaveChanges();
        //    return RedirectToAction("MyMessages", "Message");
        //}
    }
}
