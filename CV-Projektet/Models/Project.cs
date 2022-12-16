using System.ComponentModel.DataAnnotations;

namespace CV_Projektet.Models
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public List<User> Collaborators { get; set; }
        
    }
}
