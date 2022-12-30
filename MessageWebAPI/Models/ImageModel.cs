using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MessageWebAPI.Models
{
	public class ImageModel
	{
		[Key]
		public int ID { get; set; }
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Name Should be min 3 and max 20 length")]
		[DisplayName("Titel")]
		public string Title { get; set; }
		[DisplayName("Bildnamn")]
		public string Name	{ get; set; }
		[NotMapped]
		[DisplayName("Ladda upp bild")]
		public IFormFile ImageFile { get; set; }
		public string UserID { get; set; }
		[ForeignKey(nameof(UserID))]
		public virtual User user { get; set; }
	}
}
