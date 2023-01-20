using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OBE_BEL.MyInstitute_Section.InstituteBEL
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id{ get; set; }

        public Province Region { get; set; }
        [ForeignKey("Region")] public int RegionId { get; set; }

        [Required]
        public string  Name{ get; set; }

        public ICollection<Institute> Institutes { get; set; }
    }
}
