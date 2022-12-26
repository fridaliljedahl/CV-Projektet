using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Projektet.Models
{
	public class ImageModel
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID { get; set; }
		[DisplayName("Titel")]
		public string Title { get; set; }
		[DisplayName("Bildnamn")]
		public string Name	{ get; set; }
		[NotMapped]
		[DisplayName("Ladda upp bild")]
		public IFormFile ImageFile { get; set; }
	}
}
