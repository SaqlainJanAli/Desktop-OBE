using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OBE_BEL.Assessment_Section.ActivityBEL;

namespace OBE_BEL.MyInstitute_Section.CourseSectionBEL.Assessment
{
    public class ClassActivity
    {
        [Key] public int Id { get; set; }

        public CourseSection CourseSection { get; set; }
        [ForeignKey("CourseSection")]
        public int CourseSecId { get; set; }


        
        public Activity Activity { get; set; }
        [ForeignKey("Activity")] public int ActivityId { get; set; }


        [Required(ErrorMessage = "Name is not entered")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Date is Required")]
        public DateTime ActivityDate { get; set; }


        [Required(ErrorMessage = "Total Marks cannot be null")]
        public decimal TotalMarks { get; set; }

        public decimal GpaWeight { get; set; }

        public bool ComplexEP { get; set; }
        public bool IncludeGpaCal { get; set; }

        //One to many relationship with Activity Result
        public virtual ICollection<ClassActivityResult> ClassActivityResult { get; set; }
    }
}
