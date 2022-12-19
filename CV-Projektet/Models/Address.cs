using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CV_Projektet.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public int PostalCode { get; set; }
        [Required]
        public string City { get; set; }
        public virtual IEnumerable<User> Users { get; set; } = new List<User>();
    }
}
