using System.ComponentModel.DataAnnotations;

namespace CV_Projektet.Models
{
    public class ProjectDetails
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProjectLeader { get; set; }

        public virtual List<CV> CVList { get; set; } = new List<CV>();
    }
}