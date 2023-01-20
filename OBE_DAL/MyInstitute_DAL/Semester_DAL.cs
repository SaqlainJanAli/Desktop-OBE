using System;
using System.Linq;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.SemesterBEL;

namespace OBE_DAL.MyInstitute_DAL
{
    public class Semester_DAL
    {
        public object GetSemestersDAL()
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.Semesters.ToList();
            }
        }

        public ResultModel CreateSemestersDAL(Semester _semesterBEL)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                try
                {
                    _dbContext.Semesters.Add(_semesterBEL);
                    _dbContext.SaveChanges();

                    return new ResultModel
                    {
                        Data = null,
                        Message = "Semester has been created successfully",
                        Status = true  
                    };

                }
                catch (Exception e)
                {
                    return new ResultModel
                    {
                        Data = null,
                        Message = e.Message,
                        Status = false
                    };
                    //throw;
                }
            }
        }

        public object FilterByCompletedDAL(bool @checked)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.Semesters.Where(s=>s.Completed == @checked).ToList();
            }
        }

        public object FilterByResultDAL(bool @checked)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.Semesters.Where(s => s.ShowResultInGPA == @checked).ToList();
            }
        }

        public object FilterByYearDAL(string v)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.Semesters.Where(s => s.AcademicYear.ToLower().Contains(v.Trim().ToLower())).ToList();
            }
        }

        public object FilterByNameDAL(string text)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.Semesters.Where(s => s.Name.ToLower().Contains(text.Trim().ToLower())).ToList();
            }
        }

        public ResultModel UpdateSemesterDAL(Semester _semesterBEL)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {
                    var UpdEnt = _dbContext.Semesters.SingleOrDefault(S => S.Id == _semesterBEL.Id);
                    if (UpdEnt != null)
                    {
                        UpdEnt.Id = _semesterBEL.Id;
                        UpdEnt.AcademicYear = _semesterBEL.AcademicYear;
                        UpdEnt.Name = _semesterBEL.Name;
                        UpdEnt.StartDate = _semesterBEL.StartDate;
                        UpdEnt.EndDate = _semesterBEL.EndDate;
                        UpdEnt.Notes = _semesterBEL.Notes;
                        UpdEnt.Completed = _semesterBEL.Completed;
                        UpdEnt.ShowResultInGPA = _semesterBEL.ShowResultInGPA;

                        _dbContext.SaveChanges();
                        return new ResultModel
                        {
                            Data = null,
                            Message = "Semester has been updated successfully",
                            Status = true
                        };

                    }
                    else
                    {
                        return new ResultModel
                        {
                            Data = null,
                            Message = "Semester not found",
                            Status = false
                        };
                    }
                }

            }
            catch (Exception e)
            {
                return new ResultModel
                {
                    Data = null,
                    Message = e.Message,
                    Status = false
                };

                throw;
            }
            
        }

        public Semester GetSemesterById(int id)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Semesters.SingleOrDefault(S => S.Id == id);
            }
        }

        public ResultModel DeleteSemesterDAL(int id)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new  ApplicationDbContext())
                {
                    var DelEnt = _dbContext.Semesters.SingleOrDefault(S => S.Id == id);
                    if (DelEnt != null)
                    {
                        _dbContext.Semesters.Remove(DelEnt);
                        _dbContext.SaveChanges();
                        return new ResultModel
                        {
                            Data = null,
                            Message = "Semester has been deleted successfully",
                            Status = true
                        };

                    }
                    else
                    {
                        return new ResultModel
                        {
                            Data = null,
                            Message = "Semester not found",
                            Status = false
                        };
                    }

                }
            }
            catch (Exception e)
            {

                return new ResultModel
                {
                    Data = null,
                    Message = e.Message,
                    Status = false
                };

            }
        }
    }
}
