using OBE_BEL;
using OBE_BEL.MyInstitute_Section.ProgramBatchBEL;
using OBE_DAL.MyInstitute_DAL;

namespace OBE_BLL.MyInstitute_BLL
{
    public class ProgramBatch_BLL
    {
        ProgramBatch_DAL _programBatchDAL = new ProgramBatch_DAL();

        public object GetProgramBatchesBLL()
        {
            return _programBatchDAL.GetProgramBatchesDAL();
        }

        public ResultModel CreateProgramBatchBLL(ProgramBatch _programBatchBEL)
        {
            return _programBatchDAL.CreateProgramBatchDAL(_programBatchBEL);
        }

        public ResultModel DeleteProgramBLL(int iD)
        {
            return _programBatchDAL.DeleteProgramBatchDAL(iD);
        }

       

        public ProgramBatch GetProgramBatchByIdBLL(int iD)
        {
            return _programBatchDAL.GetProgramBatcheByIdDAL(iD);
        }

        public ResultModel UpdateProgramBatchBLL(ProgramBatch _programBatchBEL)
        {
            return _programBatchDAL.UpdateProgramBatchDAL(_programBatchBEL);
        }

        public object FilterByProgramBLL(int v)
        {
            return _programBatchDAL.FilterByProgramDAL(v);
        }

        public object FilterByBatchBLL(int v)
        {
            return _programBatchDAL.FilterByBatchDAL(v);
        }

        public object FilterByNameBLL(string text)
        {
            return _programBatchDAL.FilterByNameDAL(text);
        }
    }
}
