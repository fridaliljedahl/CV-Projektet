namespace MessageWebAPI.Models
{
    public class Competence
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<CV_Competences> CV_Competences { get; set; } = new List<CV_Competences>();
    }
}
