using System.ComponentModel.DataAnnotations;

namespace OBE_BEL.Admin_Section.UserBEL
{
    public class FType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
