using System.ComponentModel.DataAnnotations;

namespace OBE_BEL.MyInstitute_Section.CourseBEL
{
    public class KnowledgeProfile
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }

    }
}
