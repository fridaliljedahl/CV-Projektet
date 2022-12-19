using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CV_Projektet.Models

{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
