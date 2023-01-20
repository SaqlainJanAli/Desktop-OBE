using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OBE_BEL.Admin_Section.StudentUserBEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL;
using OBE_BEL.MyInstitute_Section.SemesterBEL;

namespace OBE_BEL.MyInstitute_Section.GpaBEL
{
    public class StudentSemesterResult
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key, ForeignKey("StudentUser")]
        [Column(Order = 1)]
        public int StudentId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key, ForeignKey("CourseSection")]
        [Column(Order = 2)]
        public int CourseSecId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key, ForeignKey("Semester")]
        [Column(Order = 3)]
        public int SemesterId { get; set; }

        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string RegistrationNo { get; set; }

        public string Name { get; set; }

        //  public decimal Lab { get; set; }
        public decimal TotalMarks { get; set; }
        public decimal ObtainedMarks { get; set; }
        public decimal Percentage { get; set; }
        public string Grade { get; set; }
        public decimal CreditHours { get; set; }
        //Relations

        public virtual StudentUser StudentUser { get; set; }
        public virtual CourseSection CourseSection { get; set; }
        public virtual Semester Semester { get; set; }

    }
}
