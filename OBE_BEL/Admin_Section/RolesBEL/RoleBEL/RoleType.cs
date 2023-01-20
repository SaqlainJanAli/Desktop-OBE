using System.ComponentModel.DataAnnotations;

namespace OBE_BEL.Admin_Section.RolesBEL.RoleBEL
{
    public class RoleType
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        public string Name{ get; set; }

        //public IEnumerable<Role> Roles { get; set; }
    }
}
