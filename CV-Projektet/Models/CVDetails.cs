namespace CV_Projektet.Models
{
    public class CVDetails 
    {
        public int ID { get; set; }
        public int TimesViewed { get; set; }

        public IEnumerable<Competence> CompetenceList { get; set; }
        public IEnumerable<Experience> ExperienceList { get; set; }
        public IEnumerable<Project> ProjectList { get; set; } = new List<Project>();
    }
}
