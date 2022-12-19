using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Projektet.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Test { get; set; }

        //public List<User> Collaborators { get; set; }
        
    }
}
