namespace CV_Projektet.Models
{
    public class Competence
    {
        public int ID { get; set; }
        public string Name { get; set; }


        public virtual IEnumerable<CV> CVs { get; set; } = new List<CV>();
    }
}
