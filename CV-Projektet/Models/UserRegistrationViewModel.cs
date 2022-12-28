using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Projektet.Models
{
    public class UserRegistrationViewModel
    {
        [Required]
        [StringLength(255)]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required]
        [RegularExpression("^(?=.*[A-Z])(?=.*[!@#$&*])(?=.*[0-9])(?=.*[a-z]).{5,}$", ErrorMessage = "Password must contains one uppercase letter, one digit, one special character and be of at least 5 characters in length")]
        [Compare("PasswordConfirmed")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        public string PasswordConfirmed { get; set; }

        [Required]
        [Display(Name = "First name")]
        [RegularExpression("^[a-zA-Z]+$",
            ErrorMessage = "First name can only contain letters")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        [RegularExpression("^[a-öA-Ö0-9]+$",
            ErrorMessage = "Last name can only contain letters")]
        public string LastName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [MaxLength(ErrorMessage = "The description can contains max 100 characters")]
        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Public profile?")]
        public bool IsPublic { get; set; }

        [Display(Name = "Phone number")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Phone number can only contain digits ")]
        public string PhoneNumber { get; set; }


        [Required]
        [Display(Name = "Street namn")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Postal code is required")]
        [RegularExpression("^[0-9]{5}$", ErrorMessage = "Postal code must consist of 5 digits")]
        [Display(Name = "Postal Code")]
        public int PostalCode { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }
        public string? returnedErrorMessage { get; set; }
    }
}
