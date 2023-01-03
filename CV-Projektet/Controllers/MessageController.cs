using CV_Projektet.Data;
using CV_Projektet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
using Castle.Core.Internal;
using System.Net.Http;
using System.Net.Http.Headers;
using System;
using System.Security.Policy;

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

        public IActionResult SendMessage(string receiverId, string receiverName)
        {
            var viewModel = new SendMessageViewModel
            {
                ReceiverId = receiverId,
                ReceiverName = receiverName,
                Text = ""
            };
            if (signInManager.IsSignedIn(User))
            {
                User user = context.Users.Find(userManager.GetUserId(User));
                viewModel.SenderId = user.Id;
                viewModel.SenderName = user.FirstName + " " + user.LastName;
            }
            SaveViewModelState(viewModel);
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(SendMessageViewModel view)
        {
            var storedViewModelJson = HttpContext.Session.GetString("viewModel");
            var storedViewModel = JsonConvert.DeserializeObject<SendMessageViewModel>(storedViewModelJson);
            storedViewModel.ErrorInfo = "";
            bool signedIn = true;
            if (!signInManager.IsSignedIn(User))
            {
                signedIn = false;
                storedViewModel.SenderName = Request.Form["SenderName"];
            }
            storedViewModel.Text = Request.Form["Text"];
            SaveViewModelState(storedViewModel);
            storedViewModel = GetViewModelState();
            if ((signedIn && !string.IsNullOrWhiteSpace(storedViewModel.Text)) ||
                (!signedIn && !string.IsNullOrWhiteSpace(storedViewModel.Text) && !string.IsNullOrWhiteSpace(storedViewModel.SenderName)))
            {
                Message msg = new Message
                {
                    Sender = storedViewModel.SenderId,
                    Receiver = storedViewModel.ReceiverId,
                    SenderName = storedViewModel.SenderName,
                    Date = DateTime.Now,
                    Read = false,
                    Text = storedViewModel.Text
                };

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                string data = JsonSerializer.Serialize(msg, options);
                var contentData = new StringContent(data, System.Text.Encoding.UTF8,
                    "application/json");

                HttpResponseMessage response = await client.PostAsync($"message", contentData);

                if (response.IsSuccessStatusCode)
                {
                    var newView = storedViewModel;
                    newView.Text = "";
                    newView.ErrorInfo = "Ditt meddelande är skickat!";
                    SaveViewModelState(newView);
                    return View(newView);
                }
                else
                {
                    storedViewModel.ErrorInfo = "Något gick fel när ditt meddelande skulle skickas.";
                    SaveViewModelState(storedViewModel);
                    return View(storedViewModel);
                }
            }
            else
            {
                storedViewModel.ErrorInfo = "Vänligen se till att fält är ifyllda";
                SaveViewModelState(storedViewModel);
                storedViewModel = GetViewModelState();

                return View(storedViewModel);
            }

        }

        public async Task<ActionResult> UpdateReadState(int messageId)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            string data = JsonSerializer.Serialize(messageId, options);
            var contentData = new StringContent(data, System.Text.Encoding.UTF8,
                "application/json");

            HttpResponseMessage response = await client.PutAsync($"message", contentData);
            return RedirectToAction("MyMessages");
        }
        public void SaveViewModelState(SendMessageViewModel viewModel)
        {
            var serializedViewModel = JsonConvert.SerializeObject(viewModel);
            HttpContext.Session.SetString("viewModel", serializedViewModel);
        }

        public SendMessageViewModel GetViewModelState()
        {
            var serializedViewModel = HttpContext.Session.GetString("viewModel");
            var viewModel = JsonConvert.DeserializeObject<SendMessageViewModel>(serializedViewModel);
            return viewModel;
        }

    }
}

