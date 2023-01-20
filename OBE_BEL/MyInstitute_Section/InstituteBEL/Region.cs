using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OBE_BEL.MyInstitute_Section.InstituteBEL
{
    [Table("Regions")]
    public class Province
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        [ForeignKey("Country")] public int CountryId { get; set; }
       
    }
}
