using System.ComponentModel.DataAnnotations;

namespace CvWebApi.Models
{
    public class CVDetails 
    {
        public CV CV { get; set; }
        public User User { get; set; }
        public IEnumerable<Competence> CompetenceList { get; set; }
        public IEnumerable<Experience> ExperienceList { get; set; }
        public IEnumerable<Project> ProjectList { get; set; } = new List<Project>();
    }
}
