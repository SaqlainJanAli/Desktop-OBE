using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OBE_BEL.Admin_Section.RolesBEL.RoleBEL
{
    public class Role
    {
        [Key]
        public int Id{ get; set; }
        [Required(ErrorMessage = "Role Name is Required")]
        [StringLength(50,ErrorMessage = "Maximum Length is 50")]
        public string Name{ get; set; }

        public RoleType RoleType { get; set; }
        [ForeignKey("RoleType")]
        public int RoleTypeId{ get; set; }

    }
}
