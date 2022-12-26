using System.ComponentModel.DataAnnotations.Schema;

namespace CvWebApi.Models
{
    public class User_Projects
    {
        public string UserID { get; set; }
        public int ProjectID { get; set; }

        [ForeignKey(nameof(UserID))]
        public virtual User User { get; set; }
        [ForeignKey(nameof(ProjectID))]
        public virtual Project Project { get; set; }


    }
}
