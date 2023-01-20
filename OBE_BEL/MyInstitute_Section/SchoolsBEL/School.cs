using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO;
using OBE_BEL.MyInstitute_Section.CampusesBEL;
using OBE_BEL.MyInstitute_Section.InstituteBEL;

namespace OBE_BEL.MyInstitute_Section.SchoolsBEL
{
    public class School
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Address{ get; set; }

        public string Notes { get; set; }

        public Campus campus { get; set; }
        [ForeignKey("campus")]
        public int CampusId { get; set; }
        public City city { get; set; }
        
        [ForeignKey("city")]
        public int CityId{ get; set; }
        public string SchoolIcon_Path { get; set; }

        [NotMapped]
        public Image SchoolIcon
        {
            get
            {
                if (!string.IsNullOrEmpty(SchoolIcon_Path))
                {
                    if (File.Exists(SchoolIcon_Path))
                    {
                        return Image.FromFile(SchoolIcon_Path);
                    }
                }
                return null;
            }
        }
    }
}
