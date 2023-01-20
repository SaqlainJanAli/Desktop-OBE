using System.ComponentModel.DataAnnotations;

namespace OBE_BEL.Assessment_Section.ActivityBEL
{
    public class AllowedOperation
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }



    }
}
