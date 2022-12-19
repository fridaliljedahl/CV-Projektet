using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CV_Projektet.Models
{
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Sender { get; set; }
        [Required]
        public string Receiver { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public bool Read { get; set; }
        [Required]
        public string Text { get; set; }

        public Message(string sender, string receiver, string text)
        {
            Sender = sender;
            Receiver = receiver;
            Date = System.DateTime.Now;
            Read = false;
            Text = text;
        }
        public Message()
        {

        }
    }
}
