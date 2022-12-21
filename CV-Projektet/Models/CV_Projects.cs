using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Projektet.Models
{
    public class CV_Projects
    {
        public int ProjectID { get; set; }
        public int CVID { get; set; }

        [ForeignKey(nameof(ProjectID))]
        public virtual Project Project { get; set; }

        [ForeignKey(nameof(CVID))]
        public virtual CV CV { get; set; }
    }
}
