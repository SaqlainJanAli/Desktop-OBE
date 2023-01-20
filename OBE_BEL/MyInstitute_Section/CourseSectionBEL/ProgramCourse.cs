using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OBE_BEL.MyInstitute_Section.CourseBEL;

namespace OBE_BEL.MyInstitute_Section.CourseSectionBEL
{
    public class ProgramCourse
    {
        [Key]
        public int Id { get; set; }
        public ProgramBatchBEL.ProgramBatch ProgramBatch { get; set; }
        [ForeignKey("ProgramBatch")]
        public int ProgramBatchId { get; set; }
        public SemesterBEL.SemesterType SemesterType { get; set; }
        [ForeignKey("SemesterType")]
        public int SemesterTypeId { get; set; }

        public int TaughInSemester { get; set; }

        public Course Course { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
    }
}
