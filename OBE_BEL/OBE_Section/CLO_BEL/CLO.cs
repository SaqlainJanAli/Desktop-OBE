using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OBE_BEL.OBE_Section.CLO_BEL
{
    [Table("CLOs")]
    public class CLO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        public bool isActive { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
