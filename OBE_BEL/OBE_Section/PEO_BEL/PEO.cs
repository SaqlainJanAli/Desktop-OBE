using System.ComponentModel.DataAnnotations;

namespace OBE_BEL.OBE_Section.PEO_BEL
{
    public class PEO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        public bool isActive { get; set; }
        public bool MapInstituteMission { get; set; }
        public bool MapInstituteVision { get; set; }
        [Required]
        public string Description{ get; set; }
        public string Elements{ get; set; }
        public string Strategies{ get; set; }

        

    }
}
