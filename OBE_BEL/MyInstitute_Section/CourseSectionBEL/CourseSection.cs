using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OBE_BEL.Admin_Section.RolesBEL;
using OBE_BEL.Admin_Section.UserBEL;
using OBE_BEL.MyInstitute_Section.CourseBEL;

namespace OBE_BEL.MyInstitute_Section.CourseSectionBEL
{
    public class CourseSection
    {
        [Key]
        public int Id{ get; set; }

        [Required]
        public string Name{ get; set; }

        public DepartmentBEL.Department Department{ get; set; }
        [ForeignKey("Department")]
        public int DepartmentId{ get; set; }

        public SemesterBEL.Semester Semester{ get; set; }
        [ForeignKey("Semester")]
        public int SemesterId{ get; set; }

        public Course Course{ get; set; }
        [ForeignKey("Course")]
        public int CourseId{ get; set; }

        //public FacultyUser MyProperty { get; set; }
        public FacultyUser FacultyUser { get; set; }
        [ForeignKey("FacultyUser")]
        public int FacultyId { get; set; }
        public bool Finished{ get; set; }
        public bool UseInOBE{ get; set; }

        [Required]
        public decimal MarksPercentage{ get; set; }

        [Required]
        public decimal StudentsPercentage{ get; set; }

        public string Section{ get; set; }

        public Gender Gender { get; set; }
        [ForeignKey("Gender")]
        public int? GenderId{ get; set; }


        public string Notes{ get; set; }


    }
}
