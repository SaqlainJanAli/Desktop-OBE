using System.Collections.Generic;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section;
using OBE_BEL.MyInstitute_Section.ProgramBEL;
using OBE_BEL.MyInstitute_Section.SemesterBEL;
using OBE_DAL;

namespace OBE_BLL.MyInstitute_BLL
{
    public class Program_BLL
    {
        Program_DAL _programDAL = new Program_DAL();

        public object GetProgramsBLL()
        {
            return _programDAL.GetProgramsDAL();
        }

        public List<ProgramLevel> GetProgramLevelsBLL()
        {
            return _programDAL.GetProgramLevelsDAL();
        }

        public List<SemesterType> GetSemesterTypesBLL()
        {
            return _programDAL.GetSemesterTypesDAL();
        }

        public List<LearningType> GetLearningTypesBLL()
        {
            return _programDAL.getLearningTypesDAL();
        }

        public List<NoOfSession> GetNoOfSessionsBLL()
        {
            return _programDAL.GetNoOfSessionsDAL();
        }

        public ResultModel CreateProgramBLL(Program _programBEL)
        {
            return _programDAL.CreateProgramDAL(_programBEL);
        }

        public ResultModel DeleteProgramBLL(int id)
        {
            return _programDAL.DeleteProgramDAL(id);
        }

        public ResultModel UpdateProgramBLL(Program _programBEL)
        {
            return _programDAL.UpdateProgramDAL(_programBEL);
        }

        public Program GetProgramByIdBLL(int id)
        {
            return _programDAL.GetProgramByIdDAL(id);
        }

        public object FilterByNameBLL(string text)
        {
            return _programDAL.FilterByNameDAL(text);
        }

        public object FilterByLevelBLL(int v)
        {
            return _programDAL.FilterByLevelDAL(v);
        }

        public object FilterByDepartBLL(int v)
        {
            return _programDAL.FilterByDepartDAL(v);
        }
    }
}
