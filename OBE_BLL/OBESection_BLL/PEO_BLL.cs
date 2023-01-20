using System.Collections.Generic;
using OBE_BEL;
using OBE_BEL.OBE_Section.PEO_BEL;
using OBE_DAL.OBESection_DAL;

namespace OBE_BLL.OBESection_BLL
{
    public class PEO_BLL
    {
        private PEO_DAL _peoDal = new PEO_DAL();
        public ResultModel CreatePEOBLL(PEO _PeoBEL)
        {
            return _peoDal.CreatePEODAL(_PeoBEL);
        }

        public ResultModel CreatePeoProgramBLL(List<PEOProgram> _newList)
        {
            return _peoDal.CreatePeoProgramDAL(_newList);
        }

        public object GetPEOsBLL()
        {
            return _peoDal.GetPEOsDAL();
        }

        public ResultModel DeletePeoBLL(int id)
        {
            return _peoDal.DeletePEODAL(id);
        }

        public PEO getPeoByIdBLL(int id)
        {
            return _peoDal.getPeoByIdDAL(id);
        }

        public List<PEOProgram> GetPeoProgramByPEOIdBLL(int id)
        {
            return _peoDal.getPeoProgByPeoIdDAL(id);
        }

        public ResultModel UpdatePeoProgramBLL(List<PEOProgram> _newList)
        {
            return _peoDal.UpdatePeoProgDAL(_newList);
        }

        public ResultModel UpdatePEOBLL(PEO _PeoBEL)
        {
            return _peoDal.UpdatePEODAL(_PeoBEL);
        }
    }
}
