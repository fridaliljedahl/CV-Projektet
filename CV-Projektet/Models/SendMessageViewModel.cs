using System.ComponentModel.DataAnnotations;

namespace CV_Projektet.Models
{
	public class SendMessageViewModel
	{		
		public string SenderId { get; set; }
        [Required(ErrorMessage = "Vänligen ange ditt namn")]
        public string SenderName { get; set; }
		[Required(ErrorMessage = "Vänligen skriv ett meddelande")]
		public string Text { get; set; }
		public string? ReceiverId { get; set; }
		public string ReceiverName { get; set; }
		public string? MessageSentMessage { get; set; }
		public string? MethodCaller { get; set; }
	}
}
