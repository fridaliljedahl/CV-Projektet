using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Projektet.Models

{
    public class User:IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string? ProfilePicture { get; set; }
        public int AdressID { get; set; }

        [ForeignKey(nameof(AdressID))]
        public virtual Address Address { get; set; }
    }
}
