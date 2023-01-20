using System.ComponentModel.DataAnnotations;

namespace OBE_BEL.MyInstitute_Section
{
    public class GPA_Method
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        public string MethodName{ get; set; }
    }
}
