using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OBE_BEL.Assessment_Section.ActivityBEL;

namespace OBE_BEL.MyInstitute_Section.CourseSectionBEL.ActivityWeight
{
    public class ActivityWeight
    {
        //[Key]
        //public int Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(Order = 1)]
        [ForeignKey("CourseSection")]
        [Key]
        public int CourseSectionId { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(Order = 2)]
        [ForeignKey("Activity")]
        [Key]
        public int ActivityId { get; set; }

        [Required]
        public decimal Weight { get; set; }



        public virtual CourseSection CourseSection { get; set; }
        public virtual Activity Activity { get; set; }
    }
}
