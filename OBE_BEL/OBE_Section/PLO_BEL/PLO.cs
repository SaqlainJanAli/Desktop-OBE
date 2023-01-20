using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OBE_BEL.OBE_Section.PLO_BEL
{
    [Table("PLOs")]
    public class PLO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        public string WACode { get; set; }

        public bool isActive { get; set; }

        public string Description { get; set; }

        public string Strategies { get; set; }

       
    }
}
