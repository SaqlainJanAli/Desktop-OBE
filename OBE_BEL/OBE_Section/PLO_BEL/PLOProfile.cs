using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OBE_BEL.MyInstitute_Section.CourseBEL;
using OBE_BEL.MyInstitute_Section.ProgramBatchBEL;
using OBE_BEL.OBE_Section.PEO_BEL;

namespace OBE_BEL.OBE_Section.PLO_BEL
{
    public class PLOProfile
    {
        [Key] public int Id { get; set; }
        
        public ProgramBatch ProgramBatch { get; set; }
        [ForeignKey("ProgramBatch")]
        public int BatchId { get; set; }

        public KnowledgeProfile KnowledgeProfile { get; set; }
        [ForeignKey("KnowledgeProfile")]
        public int KnowledgeProfileId { get; set; }

        public PEO PEO { get; set; }
        [ForeignKey("PEO")]
        public int PEOId { get; set; }

        public PLO Plo { get; set; }
        [ForeignKey("Plo")]
        public int PLOId { get; set; }


    }
}
