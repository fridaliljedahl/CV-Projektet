using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace CvWebApi.Models
{
    public class CV
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int TimesViewed { get; set; }
        public string UserID { get; set; }

		[ForeignKey(nameof(UserID))]
        public virtual User User { get; set; }

        public virtual IEnumerable<Experience> Experiences { get; set; } = new List<Experience>();
        public virtual IEnumerable<CV_Competences> CV_Competences { get; set; } = new List<CV_Competences>();
    }
}
