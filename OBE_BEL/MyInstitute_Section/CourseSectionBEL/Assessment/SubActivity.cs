using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OBE_BEL.OBE_Section.CLO_BEL;

namespace OBE_BEL.MyInstitute_Section.CourseSectionBEL.Assessment
{
    public class SubActivity
    {
        [Key]
        public int Id { get; set; }

        [Required] public string Name{ get; set; }
        [Required] public decimal MaxMarks { get; set; }
        [Required] public decimal OBEWeight { get; set; }

        public CLO Clo { get; set; }
        [ForeignKey("Clo")] public int CloId { get; set; }

        public ClassActivity ClassActivity { get; set; }
        [ForeignKey("ClassActivity")] public int ActivityId { get; set; }

        
    }
}
