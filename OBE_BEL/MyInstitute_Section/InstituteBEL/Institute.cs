using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO;

namespace OBE_BEL.MyInstitute_Section.InstituteBEL
{
    public class Institute
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public IssuingAuthority Authority { get; set; }
        [Required]
        [ForeignKey("Authority")]
        public int IssuingAuthorityId { get; set; }


        public Type InstituteType { get; set; }

        [Required]
        [ForeignKey("InstituteType")]
        public int InstituteTypeId { get; set; }


        public PLOCalculationMethod PLOCalMethod { get; set; }

        [Required]
        [ForeignKey("PLOCalMethod")]
        public int MethodId { get; set; }

        public Country country { get; set; }
        [Required]
        [ForeignKey("country")]
        public int CountryId { get; set; }

        public Province Region { get; set; }
        [ForeignKey("Region")]
        public int RegionId { get; set; }


        public City city { get; set; }
        [Required]
        [ForeignKey("city")]
        public int CityId { get; set; }

        [Required]
        public int FullGPA { get; set; }

        public int AllowAttendance { get; set; }
        public bool PublicSector { get; set; }
        [Required]
        public DateTime YearEstablished { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string WebsiteURL { get; set; }
        public string Notes { get; set; }
        [Required]
        public string Vision { get; set; }
        [Required]
        public string Logo_Path { get; set; }
        [Required]
        public string Mission { get; set; }

        [NotMapped]
        public Image LogoImage
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
