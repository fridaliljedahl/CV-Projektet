using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Projektet.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ProjectLeader { get; set; }

        public virtual IEnumerable<ProjectsInCV> ProjectsInCVs { get; set; } = new List<ProjectsInCV>();

    }
}
