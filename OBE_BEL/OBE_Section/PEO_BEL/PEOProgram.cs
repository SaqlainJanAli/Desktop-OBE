using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OBE_BEL.MyInstitute_Section.ProgramBEL;

namespace OBE_BEL.OBE_Section.PEO_BEL
{
    public class PEOProgram
    {
        [Key] public int Id { get; set; }

        public Program Program { get; set; }
        [ForeignKey("Program")] public int ProgramId { get; set; }

        [Required(ErrorMessage = "Short Name of Program is required")]
        public string ShortName { get; set; }

        public PEO PEO { get; set; }
        [ForeignKey("PEO")] public int PEOId { get; set; }

    }
}
