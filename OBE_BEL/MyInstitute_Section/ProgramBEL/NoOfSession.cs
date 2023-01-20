using System.ComponentModel.DataAnnotations;

namespace OBE_BEL.MyInstitute_Section.ProgramBEL
{
    public class NoOfSession
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int SessionCount { get; set; }
    }
}
