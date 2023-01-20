using System.ComponentModel.DataAnnotations;

namespace OBE_BEL.MyInstitute_Section.CourseBEL
{
    public class CourseLevel
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string LevelName { get; set; }

    }
}
