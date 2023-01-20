using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OBE_BEL.Assessment_Section;
using OBE_BEL.MyInstitute_Section.DepartmentBEL;
using OBE_BEL.MyInstitute_Section.SemesterBEL;

namespace OBE_BEL.MyInstitute_Section.ProgramBEL
{
    public class Program
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ShortName { get; set; }

        
        public SemesterType SemesterType { get; set; }
        [ForeignKey("SemesterType")]
        public int SemesterTypeId{ get; set; }

        public ProgramLevel ProgramLevel{ get; set; }
        [ForeignKey("ProgramLevel")]
        public int ProgramLevelId{ get; set; }

        public NoOfSession NoOfSession{ get; set; }
        [ForeignKey("NoOfSession")]
        public int NoOfSessionsId { get; set; }

        public Department Department{ get; set; }
        [ForeignKey("Department")]
        public int DepartmentId{ get; set; }

        public AssessmentMethod AssessmentMethod{ get; set; }
        [ForeignKey("AssessmentMethod")]
        
        public int MethodId{ get; set; }

        public LearningType LearningType{ get; set; }
        [ForeignKey("LearningType")]
        public int LearningTypeId{ get; set; }
        [Required]
        public float MarksPercentage{ get; set; }
        [Required]
        public float StudentPercentage{ get; set; }
        public string Vision{ get; set; }
        public string Mission{ get; set; }
    }
}
