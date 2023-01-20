using System.ComponentModel.DataAnnotations;

namespace OBE_BEL.Admin_Section.RolesBEL
{
    public class Gender
    {
        [Key]
        public int Id{ get; set; }

        [Required]
        public string Name{ get; set; }
    }
}
