using System.ComponentModel.DataAnnotations;

namespace OBE_BEL.MyInstitute_Section.CourseBEL
{
    public class BaseType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
