using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Projektet.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
		[Required(ErrorMessage = "Vänligen ange ett projektnamn.")]
        public string Name { get; set; }
		[Required(ErrorMessage = "Vänligen ange en beskrivning.")]
		public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ProjectLeaderID { get; set; }

        [ForeignKey(nameof(ProjectLeaderID))]
        public virtual User? ProjectLeader { get; set; }
        public virtual IEnumerable<User_Projects> User_Project { get; set; } = new List<User_Projects>();

    }
}
