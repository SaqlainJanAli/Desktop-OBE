using System.ComponentModel.DataAnnotations;

namespace OBE_BEL.MyInstitute_Section.CourseBEL
{
    public class DeliveryFormat
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }


    }
}
