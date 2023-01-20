using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OBE_BEL.MyInstitute_Section.ProgramBEL;

namespace OBE_BEL.MyInstitute_Section.ProgramBatchBEL
{
    public class ProgramBatch
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int AcademicYear { get; set; }

        public ProgramBEL.Program Program { get; set; }
        [ForeignKey("Program")]
        public int ProgramId { get; set; }


        [Required]
        public string ProgramBatchName { get; set; }

        public NoOfSession NoOfSession { get; set; }
        [ForeignKey("NoOfSession")]
        public int NoOfSessionId { get; set; }


        public GPA_Method GpaMethod { get; set; }
        [ForeignKey("GpaMethod")]
        public int MethodId { get; set; }

        public int PLOPassingThreshold{ get; set; }

        [Required]
        public int MarksPercentage { get; set; }
        [Required]
        public int StudentPercentage { get; set; }

        public bool Finished{ get; set; }

        public int TheoryCreditHours { get; set; }
        public int LabCreditHours { get; set; }

        public bool UseInOBE{ get; set; }


    }
}
