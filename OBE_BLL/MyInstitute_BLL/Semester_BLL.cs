using OBE_BEL;
using OBE_BEL.MyInstitute_Section.SemesterBEL;
using OBE_DAL.MyInstitute_DAL;

namespace OBE_BLL.MyInstitute_BLL
{
    public class Semester_BLL
    {
        Semester_DAL _semesterDAL = new Semester_DAL();

        public object GetSemestersBLL()
        {
            return _semesterDAL.GetSemestersDAL();
        }

        public ResultModel CreateSemesterBLL(Semester _semesterBEL)
        {
            return _semesterDAL.CreateSemestersDAL(_semesterBEL);
        }

        public ResultModel DeleteSemesterBLL(int id)
        {
            return _semesterDAL.DeleteSemesterDAL(id);
        }

        public Semester GetSemesterByIdBLL(int id)
        {
            return _semesterDAL.GetSemesterById(id);
        }

        public ResultModel UpdateSemesterBLL(Semester _semesterBEL)
        {
            return _semesterDAL.UpdateSemesterDAL(_semesterBEL);
        }

        public object FilterByNameBLL(string text)
        {
            return _semesterDAL.FilterByNameDAL(text);
        }

        public object FilterByYearBLL(string v)
        {
            return _semesterDAL.FilterByYearDAL(v);
        }

        public object FilterByCompletedBLL(bool @checked)
        {
            return _semesterDAL.FilterByCompletedDAL(@checked);

        }

        public object FilterByShowResultBLL(bool @checked)
        {
            return _semesterDAL.FilterByResultDAL(@checked);
        }
    }
}
