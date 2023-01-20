using System.ComponentModel.DataAnnotations;

namespace OBE_BEL.Admin_Section.StudentUserBEL
{
    public class Religion
    {
        [Key] public int  Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
