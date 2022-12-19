using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CV_Projektet.Models
{
    public class CV
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int TimesViewed { get; set; }

        public virtual IEnumerable<ProjectsInCV> ProjectsInCVs { get; set; } = new List<ProjectsInCV>();
        public virtual IEnumerable<Experience> Experiences { get; set; } = new List<Experience>();
    }
}
