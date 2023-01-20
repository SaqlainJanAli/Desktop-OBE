using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL;

namespace OBE_BEL.MyInstitute_Section.CourseBEL
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]
        public string Code { get; set; }

        public bool SupervisorBased{ get; set; }

        public bool Active{ get; set; }
        [Required]
        public int TheoryCreditHours{ get; set; }
        [Required]
        public int LabCreditHours{ get; set; }
        public BaseType BaseType{ get; set; }
        [ForeignKey("BaseType")]
        public int BaseTypeId{ get; set; }
        public KnowledgeArea KnowledgeArea{ get; set; }
        [ForeignKey("KnowledgeArea")]
        public int KnowledgeAreaId{ get; set; }
        public KnowledgeProfile KnowledgeProfile{ get; set; }
        [ForeignKey("KnowledgeProfile")]
        public int KnowledgeProfileId{ get; set; }
        public CourseLevel CourseLevel{ get; set; }
        [ForeignKey("CourseLevel")]
        public int CourseLevelId{ get; set; }
        public DepartmentBEL.Department Department{ get; set; }
        [ForeignKey("Department")]
        [Required]
        public int DepartmentId{ get; set; }
        public DeliveryFormat DeliveryFormat{ get; set; }
        [ForeignKey("DeliveryFormat")]
        public int DeliveryFormatId{ get; set; }
        public Course Courses{ get; set; }

        [ForeignKey("Courses")]
        public int? PreReqCourseId{ get; set; }

        public ICollection<ProgramCourse> ProgramCourses{ get; set; }
    }
}
