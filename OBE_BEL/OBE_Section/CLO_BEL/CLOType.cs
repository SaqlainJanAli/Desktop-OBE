using System.ComponentModel.DataAnnotations;

namespace OBE_BEL.OBE_Section.CLO_BEL
{
    public class CLOType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
