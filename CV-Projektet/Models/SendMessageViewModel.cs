using System.ComponentModel.DataAnnotations;

namespace CV_Projektet.Models
{
	public class SendMessageViewModel
	{		
		public string? SenderId { get; set; }
        public string? SenderName { get; set; }
		public string? Text { get; set; }
		public string? ReceiverId { get; set; }
		public string? ReceiverName { get; set; }
		public string? ErrorInfo { get; set; }
	}
}
