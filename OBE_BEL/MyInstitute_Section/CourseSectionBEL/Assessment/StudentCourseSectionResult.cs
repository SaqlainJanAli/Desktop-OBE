using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OBE_BEL.Admin_Section.StudentUserBEL;

namespace OBE_BEL.MyInstitute_Section.CourseSectionBEL.Assessment
{
    public class StudentCourseSectionResult
    {
        [Key, ForeignKey("StudentUser")]
        [Column(Order = 1)]
        public int StudentId { get; set; }

        [Key, ForeignKey("CourseSection")]
        [Column(Order = 2)]
        public int CourseSecId { get; set; }

        public string RegistrationNo { get; set; }
        public string Name { get; set; }

        public decimal Assignment1 { get; set; }
        public decimal Assignment2 { get; set; }
        public decimal Assignment3 { get; set; }
        public decimal Assignment4 { get; set; }
        public decimal Quiz1 { get; set; }
        public decimal Quiz2 { get; set; }
        public decimal Quiz3 { get; set; }
        public decimal Quiz4 { get; set; }
        public decimal Midterm { get; set; }
        public decimal Terminal { get; set; }
      //  public decimal Lab { get; set; }
        public decimal TotalMarks { get; set; }
        public decimal Percentage { get; set; }
        public string Grade { get; set; }

        //Relations

        public virtual StudentUser StudentUser { get; set; }
        public virtual CourseSection CourseSection { get; set; }


    }
}
