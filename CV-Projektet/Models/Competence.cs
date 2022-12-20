namespace CV_Projektet.Models
{
    public class Competence
    {
        public int ID { get; set; }
        public string Name { get; set; }


        public virtual IEnumerable<CV_Competence> CV_Competence { get; set; } = new List<CV_Competence>();
    }
}
