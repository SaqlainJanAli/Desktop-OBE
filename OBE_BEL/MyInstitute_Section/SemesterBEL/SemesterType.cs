using System.ComponentModel.DataAnnotations;

namespace OBE_BEL.MyInstitute_Section.SemesterBEL
{
    public class SemesterType
    {
        [Key]
        public int Id{ get; set; }

        [Required]
        public string Name { get; set; }
    }
}
