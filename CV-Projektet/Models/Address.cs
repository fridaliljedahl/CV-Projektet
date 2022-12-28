using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CV_Projektet.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required(ErrorMessage = "Ange gatunamn")]
        [Display(Name = "Gatunamn")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Ange postnummer")]
        [Display(Name = "Postnummer")]
        public int PostalCode { get; set; }
        [Required(ErrorMessage = "Ange stad")]
        [Display(Name = "Stad")]
        public string City { get; set; }
        public virtual IEnumerable<User> Users { get; set; } = new List<User>();
    }
}
