using System.ComponentModel.DataAnnotations;

namespace OBE_BEL.Assessment_Section
{
    public class AssessmentMethod
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string MethodName { get; set; }
    }
}
