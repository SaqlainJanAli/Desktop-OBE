using System.ComponentModel.DataAnnotations;

namespace OBE_BEL.Admin_Section.StudentUserBEL
{
    public class StudyMode
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
