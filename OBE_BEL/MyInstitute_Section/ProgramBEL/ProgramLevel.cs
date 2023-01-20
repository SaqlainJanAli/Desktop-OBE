using System.ComponentModel.DataAnnotations;

namespace OBE_BEL.MyInstitute_Section.ProgramBEL
{
    public class ProgramLevel
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        public string Name { get; set; }
    }
}
