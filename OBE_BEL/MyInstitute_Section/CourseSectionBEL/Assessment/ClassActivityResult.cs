using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using OBE_BEL.Admin_Section.StudentUserBEL;
using OBE_BEL.Assessment_Section.ActivityBEL;

namespace OBE_BEL.MyInstitute_Section.CourseSectionBEL.Assessment
{
    public class ClassActivityResult
    {
        //[Key]
        //public int  Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(Order = 1)]
        [Key]
        [ForeignKey("ClassActivity")]
        public int ClassActivityId { get; set; }



        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("CourseSection")]
        [Column(Order = 2)]
        [Key]
        public int CourseSecId { get; set; }



        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("StudentUser")]
        [Column(Order = 3)]
        [Key]
        public int StudentUserId { get; set; }




        [ForeignKey("Activity")]
        public int ActivityTypeId { get; set; }

     
        [Required]
        public decimal ActivityTotalMarks { get; set; }
        [Required]
        public decimal ActivityObtainedMarks { get; set; }


        /// <summary>
        /// Many to one relations
        /// </summary>
        public virtual ClassActivity ClassActivity { get; set; }
        public virtual CourseSection CourseSection { get; set; }
        public virtual StudentUser StudentUser { get; set; }
        public virtual Activity Activity { get; set; }
    }
}
