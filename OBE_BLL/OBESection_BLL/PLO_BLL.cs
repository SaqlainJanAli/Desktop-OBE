using System.Collections.Generic;
using OBE_BEL;
using OBE_BEL.OBE_Section.PLO_BEL;
using OBE_DAL.OBESection_DAL;

namespace OBE_BLL.OBESection_BLL
{
    public class PLO_BLL
    {
        private PLO_DAL _ploDal = new PLO_DAL();
        public object GetPLOsBLL()
        {
            return _ploDal.GetPLOsDAL();
        }

        public ResultModel CreatePLOBLL(PLO _ploBEL)
        {
            return _ploDal.CreatePloDAL(_ploBEL);
        }

        public ResultModel CreatePloProfilesBLL(List<PLOProfile> _ploProfiles)
        {
            return _ploDal.CreatePloProfilesDAL(_ploProfiles);
        }

        public ResultModel DeletePloBLL(int iD)
        {
            return _ploDal.DeletePLODAL(iD);
        }

        public PLO GetPLOByIdBLL(int iD)
        {
            return _ploDal.getPloByIdDAL(iD);
        }

        public List<PLOProfile> GetPloProfByPloIdBLL(int iD)
        {
            return _ploDal.getPloProfByPloIdDAL(iD);
        }

        public ResultModel UpdatePloProfilesBLL(List<PLOProfile> _ploProfiles)
        {
            return _ploDal.UpdatePloProfDAL(_ploProfiles);
        }

        public ResultModel UpdatePLOBLL(PLO _ploBEL)
        {
            return _ploDal.UpdatePloDAL(_ploBEL);
        }

        public object filterbycodebll(string text)
        {
            return _ploDal.filterbyCodeDal(text);
        }

        public object filterbyActiveBll(bool @checked)
        {
            return _ploDal.filterbyActiveDal(@checked);
        }

        public object filterbyNameBll(string text)
        {
            return _ploDal.filterbyNameDal(text);
        }
    }
}
