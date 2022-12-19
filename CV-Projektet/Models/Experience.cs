using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CV_Projektet.Models
{
    public class Experience
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public string City { get; set; }
        public string LocationName { get; set; }
        public string Description { get; set; }
        [Required]
        public int CV { get; set; } //FK

        public Experience()
        {

        }
    }
}
