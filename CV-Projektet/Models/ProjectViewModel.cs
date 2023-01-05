using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Projektet.Models
{
	public class ProjectViewModel
	{
		public int ID { get; set; }
		[Required(ErrorMessage = "Vänligen ange ett namn.")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Vänligen ange en beskrivning.")]
		public string Description { get; set; }
		public string ProjectLeaderID { get; set; }
		[Required(ErrorMessage = "Vänligen ange ett korrekt användarnamn.")]
		public string? UserName { get; set; }
		public string? ErrorMessage { get; set; }
		public virtual IEnumerable<User_Projects> User_Project { get; set; } = new List<User_Projects>();

	}


}
