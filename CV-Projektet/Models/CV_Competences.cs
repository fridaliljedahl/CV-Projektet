using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Projektet.Models
{
    public class CV_Competences
    {
        public int CVID { get; set; }
        public int CompetenceID { get; set; }


        [ForeignKey(nameof(CVID))]
        public virtual CV CV { get; set; }

        [ForeignKey(nameof(CompetenceID))]
        public virtual Competence Competence { get; set; }
    }
}
