using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MessageWebAPI.Models
{
    public class User:IdentityUser
    {        
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string? Description { get; set; }
        public bool IsPublic { get; set; }
        public bool IsActive { get; set; }
        public int? AdressID { get; set; }

        [ForeignKey(nameof(AdressID))]
        [JsonIgnore]
        public virtual Address? Address { get; set; }
        [JsonIgnore]
        public virtual CV? CV { get; set; }
        [JsonIgnore]
        public DateTime RegistrationDate { get; set; }
        public virtual ImageModel? ImageModel { get; set; }

        [JsonIgnore]
        public virtual IEnumerable<Project> LeadProjects { get; set; } = new List<Project>();
        [JsonIgnore]
        public virtual IEnumerable<Message> SentMessages { get; set; } = new List<Message>();
        [JsonIgnore]
        public virtual IEnumerable<Message> ReceivedMessages { get; set; } = new List<Message>();
        [JsonIgnore]
        public virtual IEnumerable<User_Projects> UsersAndProjects { get; set; } = new List<User_Projects>();
    }
}
