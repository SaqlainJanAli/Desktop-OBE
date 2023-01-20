using System;
using System.Collections.Generic;
using System.Linq;
using OBE_BEL;
using OBE_BEL.Admin_Section.RolesBEL;
using OBE_BEL.Admin_Section.RolesBEL.RolePrivacyBEL;
using OBE_BEL.Admin_Section.UserBEL;

namespace OBE_DAL.Admin_DAL
{
    public class User_DAL
    {
        public List<Gender> getGendersDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Genders.ToList();

            }
        }

        public List<FType> getFTypesDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.FTypes.ToList();

            }
        }

        public List<FacultyType> getFacultyTypesDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.FacultyTypes.ToList();

            }
        }

        public ResultModel CreateUserDAL(User _userBEL)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {
                    _dbContext.Users.Add(_userBEL);
                    _dbContext.SaveChanges();

                    var Ent = _dbContext.Users.SingleOrDefault(U => U.Email == _userBEL.Email);
                    int UserId = Ent.Id;
                    return new ResultModel
                    {
                        Data = UserId,
                        Message = "User has been created successfully!",
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

        public ResultModel UpdateUserDAL(User _userBEL)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {
                    var Ent = _dbContext.Users.SingleOrDefault(u => u.Id == _userBEL.Id);
                    if (Ent != null)
                    {
                        Ent.FirstName = _userBEL.FirstName;
                        Ent.LastName = _userBEL.LastName;
                        Ent.isActive = _userBEL.isActive;
                        Ent.Email = _userBEL.Email;
                        Ent.Password = _userBEL.Password;
                        Ent.RoleId = _userBEL.RoleId;
                        Ent.SchoolId = _userBEL.SchoolId;
                        Ent.ConfirmPassword = _userBEL.ConfirmPassword;
                        _dbContext.SaveChanges();

                        return new ResultModel
                        {
                            Data = null,
                            Message = "User has been Updated successfully!",
                            Status = true
                        };
                    }
                    else
                    {
                        return new ResultModel
                        {
                            Data = null,
                            Message = "User with email " + _userBEL.Email + " not found",
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

        public object CountUsersDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Users.Count();
            }
        }

        public User getuserByEmailDAL(string text)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Users.SingleOrDefault(u => u.Email.ToLower() == text.ToLower());
            }
        }

        public RolePrivacy getPrivacyByIdDAL(int roleId)
        {
            using (ApplicationDbContext _dbContext =new ApplicationDbContext() )
            {
                return _dbContext.RolePrivacies.SingleOrDefault(p => p.RoleId == roleId);
            }
        }

        public object FilterByisActiveDAL(bool @checked)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Users.Where(u => u.isActive== @checked ).Join(_dbContext.Roles,
                    u => u.RoleId,
                    r => r.Id,
                    (u, r) => new
                    {
                        ConfirmPassword = u.ConfirmPassword,
                        Password = u.Password,
                        Email = u.Email,
                        Id = u.Id,
                        Username = u.FirstName + " " + u.LastName,
                        isActive = u.isActive,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        RoleId = r.Name
                    }).ToList();

            }
        }

        public object FilterByRoleDAL(int v)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Users.Where(u => u.RoleId == v).Join(_dbContext.Roles,
                    u => u.RoleId,
                    r => r.Id,
                    (u, r) => new
                    {
                        ConfirmPassword = u.ConfirmPassword,
                        Password = u.Password,
                        Email = u.Email,
                        Id = u.Id,
                        Username = u.FirstName + " " + u.LastName,
                        isActive = u.isActive,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        RoleId = r.Name
                    }).ToList();

            }
        }

        public object FilterByEmailDAL(string text)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Users.Where(u=>u.Email.Contains(text.Trim())).Join(_dbContext.Roles,
                    u => u.RoleId,
                    r => r.Id,
                    (u, r) => new
                    {
                        ConfirmPassword = u.ConfirmPassword,
                        Password = u.Password,
                        Email = u.Email,
                        Id = u.Id,
                        Username = u.FirstName + " " + u.LastName,
                        isActive = u.isActive,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        RoleId = r.Name
                    }).ToList();

            }
        }

        public List<User> getEmailsDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {

                return _dbContext.Users.ToList();
            }
        }

        public ResultModel UpdateFacultyDAL(FacultyUser _facultyUserBEL)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {
                    var Ent = _dbContext.FacultyUsers.SingleOrDefault(u => u.Id == _facultyUserBEL.Id);
                    if (Ent != null)
                    {
                        Ent.MiddleName = _facultyUserBEL.MiddleName;
                        Ent.Active = _facultyUserBEL.Active;
                        Ent.CNIC = _facultyUserBEL.CNIC;
                        Ent.DepartmentId = _facultyUserBEL.DepartmentId;
                        Ent.Designation = _facultyUserBEL.Designation;
                        Ent.FTypeId = _facultyUserBEL.FTypeId;
                        Ent.FacultyTypeId = _facultyUserBEL.FacultyTypeId;
                        Ent.GenderId = _facultyUserBEL.GenderId;
                        Ent.JoiningDate = _facultyUserBEL.JoiningDate;
                        Ent.LeavingDate = _facultyUserBEL.LeavingDate;
                        Ent.MobileNo = _facultyUserBEL.MobileNo;
                        Ent.Ph_D = _facultyUserBEL.Ph_D;
                        Ent.UserId = _facultyUserBEL.UserId;

                        _dbContext.SaveChanges();

                        return new ResultModel
                        {
                            Data = null,
                            Message = "User has been Updated successfully!",
                            Status = true
                        };
                    }
                    else
                    {
                        return new ResultModel
                        {
                            Data = null,
                            Message = "Faculty with Id " + _facultyUserBEL.Id + " not found",
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

        public ResultModel DeleteUserDAL(int id)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
                {
                    var Ent = _dbContext.Users.SingleOrDefault(u => u.Id == id);
                    if (Ent != null)
                    {
                        _dbContext.Users.Remove(Ent);
                        _dbContext.SaveChanges();
                        return new ResultModel
                        {
                            Data = null,
                            Message = "User has been deleted successfully",
                            Status = true
                        };

                    }
                    else
                    {
                        return new ResultModel
                        {
                            Data = null,
                            Message = "User with this email not found in Database ",
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

        public FacultyUser GetFacultyByIdDAL(int id)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.FacultyUsers.SingleOrDefault(F => F.UserId == id);
            }
        }

        public User GetUserByIdDAL(int id)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Users.SingleOrDefault(U => U.Id == id);
            }
        }

        public object GetFacultiesDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.FacultyUsers.Join(
                    _dbContext.Users,
                    f => f.UserId,
                    u => u.Id,
                    (f, u) => new
                    {
                        Id = f.Id,
                        Name = u.FirstName + " " + u.LastName
                    }).ToList();
            }
        }

        public ResultModel CreateFacultyDAL(FacultyUser _facultyUserBEL)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {
                    _dbContext.FacultyUsers.Add(_facultyUserBEL);
                    _dbContext.SaveChanges();
                    return new ResultModel
                    {
                        Data = null,
                        Message = "User and Faculty has been created successfully!",
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

        public object GetUsersDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Users.Join(_dbContext.Roles,
                    u => u.RoleId,
                    r => r.Id,
                    (u, r) => new
                    {
                        ConfirmPassword = u.ConfirmPassword,
                        Password = u.Password,
                        Email = u.Email,
                        Id = u.Id,
                        Username = u.FirstName + " " + u.LastName,
                        isActive = u.isActive,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        RoleId = r.Name
                    }).ToList();

            }
        }
    }
}
