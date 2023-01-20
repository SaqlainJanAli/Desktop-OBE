using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OBE_BEL.Admin_Section.StudentUserBEL;

namespace OBE_BEL.MyInstitute_Section.CourseSectionBEL.Class_Students
{
    public class EnrollStudent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("CourseSection")]
        [Column(Order = 1)]
        [Key]
        public int CourseSectionId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("StudentUser")]
        [Column(Order = 2)]
        [Key]
        public int StudentUserId { get; set; }

        public CourseSection CourseSection { get; set; }
        public StudentUser StudentUser { get; set; }

    }
}
