using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MessageWebAPI.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ProjectLeaderID { get; set; }

        [ForeignKey(nameof(ProjectLeaderID))]
        public virtual User ProjectLeader { get; set; }
        public virtual IEnumerable<User_Projects> User_Project { get; set; } = new List<User_Projects>();

    }
}
