using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Projektet.Models

{
    public class User:IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ProfilePicture { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [MaxLength]
        public string? Description { get; set; }
        public int? AdressID { get; set; }

        [ForeignKey(nameof(AdressID))]
        public virtual Address? Address { get; set; }
        public virtual CV? CV { get; set; }

        public virtual IEnumerable<Project> LeadProjects { get; set; } = new List<Project>();
        public virtual IEnumerable<Message> SentMessages { get; set; } = new List<Message>();
        public virtual IEnumerable<Message> ReceivedMessages { get; set; } = new List<Message>();
        public virtual IEnumerable<User_Projects> UsersAndProjects { get; set; } = new List<User_Projects>();
    }
}
