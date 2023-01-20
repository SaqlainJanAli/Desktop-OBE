using OBE_BEL.OBE_Section.PLO_BEL;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OBE_BEL.MyInstitute_Section.CourseBEL;

namespace OBE_BEL.OBE_Section.CLO_BEL
{
    public class CLOCourse
    {
        //[Key]
        //public int Id { get; set; }


        [Column(Order = 1)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("CLO")]
        public int CLOId { get; set; }

        [Column(Order = 2)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("Course")]
        public int CourseId { get; set; }


        [Column(Order = 3)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("PLO")]
        public int PLO_Id { get; set; }



        [ForeignKey("CLOType")]
        public int Type_Id { get; set; }




        public virtual CLO CLO { get; set; }
        public virtual Course Course { get; set; }
        public virtual PLO PLO { get; set; }
        public virtual CLOType CLOType { get; set; }


    }
}
