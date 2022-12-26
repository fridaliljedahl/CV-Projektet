using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CvWebApi.Models
{
    public class UserRegistrationViewModel
    {
        [Required(ErrorMessage = "Vänligen ange ett användarnamn.")]
        [StringLength(255)]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Vänligen ange ett lösenord.")]
        [DataType(DataType.Password)]
        [Compare("PasswordConfirmed")]
        public string Password { get; set; }



        [Required(ErrorMessage = "Vänligen bekräfta lösenordet.")]
        [DataType(DataType.Password)]
        [Display(Name = "Bekräfta lösenordet.")]
        public string PasswordConfirmed { get; set; }
    }
}
