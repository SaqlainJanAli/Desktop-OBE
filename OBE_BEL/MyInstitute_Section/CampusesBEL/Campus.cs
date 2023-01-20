using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO;
using OBE_BEL.MyInstitute_Section.InstituteBEL;

namespace OBE_BEL.MyInstitute_Section.CampusesBEL
{
    public class Campus
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(60,ErrorMessage ="Maximum limit is 60 characters")]
        public string Name { get; set; }

        public Institute institute { get; set; }

       
        [Display(Name ="University")]
        [ForeignKey("institute")]
        public int University_Id { get; set; }

        public City city { get; set; }


        [Display(Name = "City")]
        [ForeignKey("city")]
        public int CityId{ get; set; }
        
        public string Address { get; set; }
        public string  Notes{ get; set; }
        public string HeaderImage_Path { get; set; }

        [NotMapped]
        public Image HeaderImage
        {
            get
            {
                if (!string.IsNullOrEmpty(HeaderImage_Path))
                {
                    if (File.Exists(HeaderImage_Path))
                    {
                        return Image.FromFile(HeaderImage_Path);
                    }


                }
                return null;
            }
        }
    }
}
