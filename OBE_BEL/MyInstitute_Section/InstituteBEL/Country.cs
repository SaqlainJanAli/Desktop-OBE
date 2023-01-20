using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OBE_BEL.MyInstitute_Section.InstituteBEL
{
    public class Country
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Language { get; set; }
        public ICollection<Institute> Institutes { get; set; }
    }
}
