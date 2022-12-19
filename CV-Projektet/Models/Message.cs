using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CV_Projektet.Models
{
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public DateTime Date { get; set; }
        public bool Read { get; set; }
        public string Text { get; set; }


        [ForeignKey(nameof(Sender))]
        public virtual User UserSender { get; set; }

        [ForeignKey(nameof(Receiver))]
        public virtual User UserReceiver { get; set; }

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
