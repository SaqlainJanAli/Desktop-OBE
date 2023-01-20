using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL;

namespace OBE_BEL.Assessment_Section.ActivityBEL
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }

        [Required] public string Name { get; set; }

        public string ShortName { get; set; }

        [ForeignKey("CourseSection")]
        public int CourseSectionId { get; set; }
        public CourseSection CourseSection { get; set; }
        //public bool isRubric { get; set; }
        //public AllowedOperation AllowedOperation { get; set; }
        //[ForeignKey("AllowedOperation")] public int AllowedOpId { get; set; }


    }
}
