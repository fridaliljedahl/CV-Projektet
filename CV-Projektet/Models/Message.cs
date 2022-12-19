using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CV_Projektet.Models
{
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Sender { get; set; }
        public int Receiver { get; set; }
        public DateTime Date { get; set; }
        public bool Read { get; set; }
        public string Text { get; set; }

        //public Message(int sender, int receiver, string text)
        //{
        //    Sender = sender;
        //    Receiver = receiver;
        //    Date = System.DateTime.Now;
        //    Read = false;
        //    Text = text;
        //}
    }
}
