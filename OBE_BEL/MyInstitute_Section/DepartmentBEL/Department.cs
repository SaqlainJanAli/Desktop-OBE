using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO;
using OBE_BEL.Assessment_Section;

namespace OBE_BEL.MyInstitute_Section.DepartmentBEL
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string ShortName { get; set; }

        public bool isActive { get; set; }
        public bool AllowFaculty { get; set; }

        public SchoolsBEL.School School {get; set;}
        [ForeignKey("School")]
        public int SchoolId{ get; set; }

        public GPA_Method GpaMethod{ get; set; }
        [ForeignKey("GpaMethod")]
        public int GPAMethodId{ get; set; }


        public int Attendance { get; set; }


        public AssessmentMethod Method{ get; set; }
        [ForeignKey("Method")]
        public int AssessmentMethodId { get; set; }
        public int ActivitiesInDays{ get; set; }
        public string Vision{ get; set; }
        public string Mission{ get; set; }
        public string Logo_Path{ get; set; }

        [NotMapped]

        public Image Depart_Logo
        {
            get
            {
                if (!string.IsNullOrEmpty(Logo_Path))
                {
                    if (File.Exists(Logo_Path))
                    {
                        return Image.FromFile(Logo_Path);
                    }
                }
                return null;
            }

        }
    }
}
