using System.ComponentModel.DataAnnotations;

namespace CV_Projektet.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Vänligen ange ett korrekt användarnamn.")]
        [StringLength(255)]

        public string UserName { get; set; }

        [Required(ErrorMessage = "Vänligen ange ett korrekt lösenord.")]
        [DataType(DataType.Password)]

        public string Password { get; set; }

        public bool RememberMe { get; set; }

        public string? ErrorMessage { get; set; }
    }
}
