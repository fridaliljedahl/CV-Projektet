using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CvWebApi.Models
{
    public class Experience
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string City { get; set; }
        public string Place { get; set; }
        public string Description { get; set; }

        public int CVID { get; set; }

        [ForeignKey(nameof(CVID))]
        public virtual CV CV { get; set; }

        public Experience()
        {

        }
    }
}
