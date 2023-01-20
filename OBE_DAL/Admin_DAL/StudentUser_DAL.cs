using System;
using System.Collections.Generic;
using System.Linq;
using OBE_BEL;
using OBE_BEL.Admin_Section.StudentUserBEL;

namespace OBE_DAL.Admin_DAL
{
    public class StudentUser_DAL
    {
        //Read
        public List<StudentUser> GetStudentUsersDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.StudentUsers.ToList();
            }
        }
        public List<StudyMode> GetStudyModesDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.StudyModes.ToList();
            }
        }
        public List<Religion> GetReligionsDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Religions.ToList();
            }
        }
        public List<Status> GetStatusesDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Statuses.ToList();
            }
        }
        public List<HSSCType> GetHsscTypesDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.HsscTypes.ToList();
            }
        }
        public List<BScType> GetBscTypesDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.BScTypes.ToList();
            }
        }
        public List<AdmissionType> GetAdmissionTypesDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.AdmissionTypes.ToList();
            }
        }
        public List<AdmissionCategory> GetAdmissionCategoDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.AdmissionCategories.ToList();
            }
        }
        public List<Quota> GetQuotasDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Quotas.ToList();
            }
        }
        public StudentUser GetStudentUserByIdDAL(int id)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.StudentUsers.FirstOrDefault(s => s.Id == id);
            }
        }
        public StudyMode getStudyModeByIdDAL(int stdUserStudyModeId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.StudyModes.FirstOrDefault(s => s.Id == stdUserStudyModeId);
            }
        }
        public Status GetStatusByIdDAL(int stdUserStatusId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Statuses.FirstOrDefault(s => s.Id == stdUserStatusId);
            }

        }
        public HSSCType GetHsscTypesByIdDAL(int stdUserHsscTypeId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.HsscTypes.FirstOrDefault(s => s.Id == stdUserHsscTypeId);
            }
        }
        public BScType GetBscTypeByIdDAL(int stdUserBscTypeId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.BScTypes.FirstOrDefault(s => s.Id == stdUserBscTypeId);
            }

        }
        public Quota GetQuotaByIdDAL(int stdUserQuotaId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Quotas.FirstOrDefault(s => s.Id == stdUserQuotaId);
            }

        }
        public AdmissionType GetAdmissionTypeByIdDAL(int? stdUserAdmissionTypeId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.AdmissionTypes.FirstOrDefault(s => s.Id == stdUserAdmissionTypeId);
            }

        }
        public AdmissionCategory GetAdmnCategoryByIdDAL(int? stdUserAdmissionCategoryId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.AdmissionCategories.FirstOrDefault(s => s.Id == stdUserAdmissionCategoryId);
            }
        }
        public object GetStudentusersByBatchIdDAL(int selectedBatchId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.StudentUsers.Where(s => s.ProgramBatchId == selectedBatchId).ToList();
            }

        }


        //Create
        public ResultModel createStudentDAL(StudentUser studentUserBel)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    _dbContext.StudentUsers.Add(studentUserBel);
                    _dbContext.SaveChanges();
                    return new ResultModel()
                    {
                        Data = null,
                        Message = "Student User Added Successfully!",
                        Status = true
                    };
                }
                catch (Exception e)
                {
                    return new ResultModel()
                    {
                        Data = null,
                        Message = e.Message,
                        Status = false
                    };
                }
            }
        }




        //Delete
        public ResultModel DeleteStudentUserDAL(int id)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {
                    var student = _dbContext.StudentUsers.SingleOrDefault(s => s.Id == id);
                    if (student != null)
                    {
                        _dbContext.StudentUsers.Remove(student);
                        _dbContext.SaveChanges();
                        return new ResultModel()
                        {
                            Data = null,
                            Message = "Student User Deleted Successfully!",
                            Status = true
                        };
                    }
                    return new ResultModel()
                    {
                        Data = null,
                        Message = $"Student User with Id : {id} not found!",
                        Status = false
                    };

                }
            }
            catch (Exception e)
            {
                return new ResultModel()
                {
                    Data = null,
                    Message = e.Message,
                    Status = false
                };
            }
        }




        //Update

        public ResultModel UpdateStudentUserDAL(StudentUser studentUserBel)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {
                    var student = _dbContext.StudentUsers.SingleOrDefault(s => s.Id == studentUserBel.Id);
                    if (student != null)
                    {
                        //_dbContext.StudentUsers.Upd(student);

                        student.RegistrationNo = studentUserBel.RegistrationNo;
                        student.Name = studentUserBel.Name;
                        student.RollNo = studentUserBel.RollNo;
                        student.ERPId = studentUserBel.ERPId;
                        student.ProgramBatchId = studentUserBel.ProgramBatchId;
                        student.GenderId = studentUserBel.GenderId;
                        student.ReligionId = studentUserBel.ReligionId;
                        student.DateOfBirth = studentUserBel.DateOfBirth;
                        student.StudyModeId = studentUserBel.StudyModeId;
                        student.StatusId = studentUserBel.StatusId;
                        student.isLocal = studentUserBel.isLocal;
                        student.FatherName = studentUserBel.FatherName;
                        student.Email = studentUserBel.Email;
                        student.CNIC = studentUserBel.CNIC;
                        student.Passport = studentUserBel.Passport;
                        student.PhoneNo = studentUserBel.PhoneNo;
                        student.MobileNo = studentUserBel.MobileNo;
                        student.PermanentAddress = studentUserBel.PermanentAddress;
                        student.CityId = studentUserBel.CityId;
                        student.District = studentUserBel.District;
                        student.RegionId = studentUserBel.RegionId;
                        student.CountryId = studentUserBel.CountryId;
                        student.PostalAddress = studentUserBel.PostalAddress;
                        student.HsscTypeId = studentUserBel.HsscTypeId;
                        student.HsscMarksPercent = studentUserBel.HsscMarksPercent;
                        student.BscTypeId = studentUserBel.BscTypeId;
                        student.BscMarksPercent = studentUserBel.BscMarksPercent;
                        student.QuotaId = studentUserBel.QuotaId;
                        student.EntryTestMarks = studentUserBel.EntryTestMarks;
                        student.ApplicationNo = studentUserBel.ApplicationNo;
                        student.AdmissionDate = studentUserBel.AdmissionDate;
                        student.AdmissionTypeId = studentUserBel.AdmissionTypeId;
                        student.AdmissionCategoryId = studentUserBel.AdmissionCategoryId;
                        student.ExtraNotes = studentUserBel.ExtraNotes;

                        _dbContext.SaveChanges();
                        return new ResultModel()
                        {
                            Data = null,
                            Message = "Student User been Updated Successfully!",
                            Status = true
                        };
                    }
                    return new ResultModel()
                    {
                        Data = null,
                        Message = $"Student User with Id : {studentUserBel.Id} not found!",
                        Status = false
                    };

                }
            }
            catch (Exception e)
            {
                return new ResultModel()
                {
                    Data = null,
                    Message = e.Message,
                    Status = false
                };
            }
        }

        
    }
}

