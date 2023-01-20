using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OBE_BEL.MyInstitute_Section.InstituteBEL
{
   public class Type
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        [StringLength(50,ErrorMessage = "Maximum length is 50")]
        public string Name{ get; set; }

        public ICollection<Institute> Institutes { get; set; }
    }
}
