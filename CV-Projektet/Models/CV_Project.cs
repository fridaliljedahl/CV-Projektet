using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Projektet.Models
{
    public class CV_Project
    {
        public int ProjectID { get; set; }
        public int CVID { get; set; }

        [ForeignKey(nameof(ProjectID))]
        public Project Project { get; set; }

        [ForeignKey(nameof(CVID))]
        public CV CV { get; set; }
    }
}
