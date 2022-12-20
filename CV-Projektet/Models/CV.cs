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

        public virtual IEnumerable<CV_Projects> CV_Project { get; set; } = new List<CV_Projects>();
        public virtual IEnumerable<Experience> Experiences { get; set; } = new List<Experience>();
        public virtual IEnumerable<CV_Competences> CV_Competences { get; set; } = new List<CV_Competences>();
    }
}
