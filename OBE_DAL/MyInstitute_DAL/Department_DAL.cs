using System;
using System.Collections.Generic;
using System.Linq;
using OBE_BEL;
using OBE_BEL.Assessment_Section;
using OBE_BEL.MyInstitute_Section;
using OBE_BEL.MyInstitute_Section.DepartmentBEL;
using OBE_BEL.ViewModels;

namespace OBE_DAL.MyInstitute_DAL
{
    public class Department_DAL
    {
        //Create
        public ResultModel CreateDepartmentDAL(Department _departmentBEL)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
                {
                    _dbContext.Departments.Add(_departmentBEL);
                    _dbContext.SaveChanges();


                    return new ResultModel
                    {
                        Data = null,
                        Message = "Department has been created successfully",
                        Status = true
                    };
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
        

        //Update

        public ResultModel UpdateDepartmentDAL(Department _departmentBEL)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {

                    var UpdEnt = _dbContext.Departments.SingleOrDefault(D => D.Id == _departmentBEL.Id);
                    if (UpdEnt != null)
                    {
                        UpdEnt.Id = _departmentBEL.Id;
                        UpdEnt.Name = _departmentBEL.Name;
                        UpdEnt.ShortName = _departmentBEL.ShortName;
                        UpdEnt.isActive = _departmentBEL.isActive;
                        UpdEnt.AllowFaculty = _departmentBEL.AllowFaculty;
                        UpdEnt.Attendance = _departmentBEL.Attendance;
                        UpdEnt.ActivitiesInDays = _departmentBEL.ActivitiesInDays;
                        UpdEnt.AssessmentMethodId = _departmentBEL.AssessmentMethodId;
                        UpdEnt.GPAMethodId = _departmentBEL.GPAMethodId;
                        UpdEnt.Logo_Path = _departmentBEL.Logo_Path;
                        UpdEnt.Vision = _departmentBEL.Vision;
                        UpdEnt.Mission = _departmentBEL.Mission;

                        _dbContext.SaveChanges();
                        return new ResultModel
                        {
                            Data = null,
                            Message = "Department has been updated successfully",
                            Status = true

                        };

                    }
                    else
                    {
                        return new ResultModel
                        {
                            Data = null,
                            Message = "Department not found",
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


        //Delete

        public ResultModel DeleteDepartmentDAL(int iD)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {
                    var DelEnt = _dbContext.Departments.SingleOrDefault(D => D.Id == iD);
                    if (DelEnt != null)
                    {
                        _dbContext.Departments.Remove(DelEnt);
                        _dbContext.SaveChanges();

                        return new ResultModel
                        {
                            Data = null,
                            Message = "Department deleted successfully",
                            Status = true
                        };

                    }
                    else
                    {
                        return new ResultModel
                        {
                            Data = null,
                            Message = "Department not found",
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


        //Read
        public List<GPA_Method> GetGPAMethodsDAL()
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.GPAMethods.ToList();
            }
        }

        public List<AssessmentMethod> GetAssessmentMethodsDAL()
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.AssessmentMethods.ToList();
            }
        }
        public Department GetDepartmentByIdDAL(int iD)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                //return _dbContext.Departments.Join
                //    (_dbContext.Schools,
                //    d => d.SchoolId,
                //    s => s.Id,
                //    (d, s) => new {
                //        Id = d.Id,
                //        Name = d.Name,
                //        d.AssessmentMethodId,
                //        GpaMethodId = d.GPAMethodId,
                //        Attendance = d.Attendance,
                //        isActive = d.isActive,
                //        Mission = d.Mission,
                //        Vision = d.Vision,
                //        Logo_Path = d.Logo_Path,

                //        SchoolId = s.Name
                //    })

                //    .Join
                //    (_dbContext.AssessmentMethods,
                //    d => d.AssessmentMethodId,
                //    a => a.Id,
                //    (d, a) => new
                //    {
                //        Id = d.Id,
                //        Name = d.Name,
                //        SchoolId = d.SchoolId,
                //        GpaMethodId = d.GpaMethodId,
                //        Attendance = d.Attendance,
                //        isActive = d.isActive,
                //        Mission = d.Mission,
                //        Vision = d.Vision,
                //        Logo_Path = d.Logo_Path,

                //        AssessmentMethodId = a.MethodName
                //    })

                //    .Join(_dbContext.GPAMethods,
                //    d => d.GpaMethodId,
                //    g => g.Id,
                //    (d, g) => new
                //    {
                //        Id = d.Id,
                //        Name = d.Name,
                //        SchoolId = d.SchoolId,
                //        Attendance = d.Attendance,
                //        isActive = d.isActive,
                //        AssessmentMethodId = d.AssessmentMethodId,
                //        Mission = d.Mission,
                //        Vision = d.Vision,
                //        Logo_Path = d.Logo_Path,

                //        GpaMethodId = g.MethodName
                //    })
                //    .ToList();
                return _dbContext.Departments.SingleOrDefault(D => D.Id == iD);
            }
        }

        public List<VM_DepartmentSchool> GetDepartmentsDAL()
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {

                return _dbContext.Departments.Join
                    (_dbContext.Schools,
                        d => d.SchoolId,
                        s => s.Id,
                        (d, s) => new {
                            Id = d.Id,
                            Name = d.Name,
                            d.AssessmentMethodId,
                            GpaMethodId = d.GPAMethodId,
                            Attendance = d.Attendance,
                            isActive = d.isActive,
                            Logo_Path = d.Logo_Path,

                            SchoolId = s.Name
                        })

                    .Join
                    (_dbContext.AssessmentMethods,
                        d => d.AssessmentMethodId,
                        a => a.Id,
                        (d, a) => new
                        {
                            Id = d.Id,
                            Name = d.Name,
                            SchoolId = d.SchoolId,
                            GpaMethodId = d.GpaMethodId,
                            Attendance = d.Attendance,
                            isActive = d.isActive,
                            Logo_Path = d.Logo_Path,

                            AssessmentMethodId = a.MethodName
                        })

                    .Join(_dbContext.GPAMethods,
                        d => d.GpaMethodId,
                        g => g.Id,
                        (d, g) => new VM_DepartmentSchool()
                        {
                            Id = d.Id,
                            Name = d.Name,
                            SchoolId = d.SchoolId,
                            Attendance = d.Attendance,
                            isActive = d.isActive,
                            AssessmentMethodId = d.AssessmentMethodId,
                            Logo_Path  = d.Logo_Path,
                            GpaMethodId = g.MethodName
                        })
                    .ToList();
            }
        }


        public List<VM_DepartmentSchool> FilterBySchoolDAL(int v)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.Departments.Where(d => d.SchoolId == v).Join
                    (_dbContext.Schools,
                        d => d.SchoolId,
                        s => s.Id,
                        (d, s) => new {
                            Id = d.Id,
                            Name = d.Name,
                            d.AssessmentMethodId,
                            GpaMethodId = d.GPAMethodId,
                            Attendance = d.Attendance,
                            isActive = d.isActive,
                            Logo_Path = d.Logo_Path,

                            SchoolId = s.Name
                        })

                    .Join
                    (_dbContext.AssessmentMethods,
                        d => d.AssessmentMethodId,
                        a => a.Id,
                        (d, a) => new
                        {
                            Id = d.Id,
                            Name = d.Name,
                            SchoolId = d.SchoolId,
                            GpaMethodId = d.GpaMethodId,
                            Attendance = d.Attendance,
                            isActive = d.isActive,
                            Logo_Path = d.Logo_Path,

                            AssessmentMethodId = a.MethodName
                        })

                    .Join(_dbContext.GPAMethods,
                        d => d.GpaMethodId,
                        g => g.Id,
                        (d, g) => new VM_DepartmentSchool()
                        {
                            Id = d.Id,
                            Name = d.Name,
                            SchoolId = d.SchoolId,
                            Attendance = d.Attendance,
                            isActive = d.isActive,
                            AssessmentMethodId = d.AssessmentMethodId,
                            Logo_Path = d.Logo_Path,
                            GpaMethodId = g.MethodName
                        })
                    .ToList();
            }
        }

        public List<VM_DepartmentSchool> FilterByNameDAL(string text)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.Departments.Where(d => d.Name.Contains(text.Trim())).Join
                    (_dbContext.Schools,
                        d => d.SchoolId,
                        s => s.Id,
                        (d, s) => new {
                            Id = d.Id,
                            Name = d.Name,
                            d.AssessmentMethodId,
                            GpaMethodId = d.GPAMethodId,
                            Attendance = d.Attendance,
                            isActive = d.isActive,
                            Logo_Path = d.Logo_Path,

                            SchoolId = s.Name
                        })

                    .Join
                    (_dbContext.AssessmentMethods,
                        d => d.AssessmentMethodId,
                        a => a.Id,
                        (d, a) => new
                        {
                            Id = d.Id,
                            Name = d.Name,
                            SchoolId = d.SchoolId,
                            GpaMethodId = d.GpaMethodId,
                            Attendance = d.Attendance,
                            isActive = d.isActive,
                            Logo_Path = d.Logo_Path,

                            AssessmentMethodId = a.MethodName
                        })

                    .Join(_dbContext.GPAMethods,
                        d => d.GpaMethodId,
                        g => g.Id,
                        (d, g) => new VM_DepartmentSchool()
                        {
                            Id = d.Id,
                            Name = d.Name,
                            SchoolId = d.SchoolId,
                            Attendance = d.Attendance,
                            isActive = d.isActive,
                            AssessmentMethodId = d.AssessmentMethodId,
                            Logo_Path = d.Logo_Path,
                            GpaMethodId = g.MethodName
                        })
                    .ToList();

            }
        }
        public int CountDepartDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Departments.Count();
            }
        }

    }
}
