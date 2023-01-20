using System;
using System.ComponentModel.DataAnnotations;

namespace OBE_BEL.MyInstitute_Section.SemesterBEL
{
    public class Semester
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string AcademicYear { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Notes { get; set; }

        public bool Completed { get; set; }

        public bool ShowResultInGPA { get; set; }

    }
}
