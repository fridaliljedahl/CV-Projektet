using System.ComponentModel.DataAnnotations.Schema;

namespace MessageWebAPI.Models
{
    public class CV_Projects
    {
        public int ProjectID { get; set; }
        public int CVID { get; set; }

        [ForeignKey(nameof(ProjectID))]
        public Project Project { get; set; }

        [ForeignKey(nameof(CVID))]
        public CV CV { get; set; }
    }
}
