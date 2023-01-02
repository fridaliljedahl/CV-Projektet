using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CV_Projektet.Models
{
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        [Compare("CurrentPassword", ErrorMessage =
            "The new password and confirmation password do not match.")]
        public string CurrentPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        [RegularExpression("^(?=.*[A-Z])(?=.*[!@#$&*])(?=.*[0-9])(?=.*[a-z]).{5,}$", ErrorMessage = "Password must contain one uppercase letter, one digit, one special character and must be of at least 5 characters in length")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage =
            "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string? ErrorMessage { get; set; }
        
    }
}
