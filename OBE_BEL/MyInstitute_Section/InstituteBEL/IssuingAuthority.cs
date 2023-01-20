using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OBE_BEL.MyInstitute_Section.InstituteBEL
{
    public class IssuingAuthority
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        [StringLength(30)]
        public string AuthorityName{ get; set; }

        public ICollection<Institute> Institutes { get; set; }
    }
}
