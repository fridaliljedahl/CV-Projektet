using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Projektet.Models
{
    public class CV_Competences
    {
        public int CVID { get; set; }
        public int CompetenceID { get; set; }


        [ForeignKey(nameof(CVID))]
        public CV CV { get; set; }

        [ForeignKey(nameof(CompetenceID))]
        public Competence Competence { get; set; }
    }
}
