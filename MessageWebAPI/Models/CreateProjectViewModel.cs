using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MessageWebAPI.Models
{
	public class CreateProjectViewModel
	{
        [Required(ErrorMessage = "Vänligen ange projektnamn")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Vänligen ange projektbeskrivning")]
        public string Description { get; set; }
        public string ProjectLeaderUserName { get; set; }

        public string? ErrorMessage { get; set; }
    }

}
