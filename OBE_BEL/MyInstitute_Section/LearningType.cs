using System.ComponentModel.DataAnnotations;

namespace OBE_BEL.MyInstitute_Section
{
    public class LearningType
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        public string Name{ get; set; }
    }
}
