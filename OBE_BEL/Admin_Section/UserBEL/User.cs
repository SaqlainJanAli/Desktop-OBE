using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OBE_BEL.Admin_Section.RolesBEL.RoleBEL;
using OBE_BEL.MyInstitute_Section.SchoolsBEL;

namespace OBE_BEL.Admin_Section.UserBEL
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public Role Role { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }

        public School School { get; set; }
        [ForeignKey("School")]
        public int SchoolId { get; set; }

        public bool isActive { get; set; }

        [Required]

        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
    }
}
