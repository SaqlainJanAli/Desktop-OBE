using System;
using System.Collections.Generic;
using System.Linq;
using OBE_BEL;
using OBE_BEL.Admin_Section.RolesBEL.RoleBEL;
using OBE_BEL.Admin_Section.RolesBEL.RolePrivacyBEL;

namespace OBE_DAL.Admin_DAL
{
    public class Role_DAL
    {
        public object GetRoleTypesDAL()
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.RoleTypes.ToList();

            }
        }

        public ResultModel CreateRoleDAL(Role _roleBEL)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {
                    _dbContext.Roles.Add(_roleBEL);
                    _dbContext.SaveChanges();


                    return new ResultModel
                    {
                        Data = null,
                        Message = "Role has been created successfully",
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

        public ResultModel UpdatePrivacyDAL(RolePrivacy rolePrivacyBEL)
        {
            try
            {
                using (ApplicationDbContext _dbContext =new ApplicationDbContext() )
                {
                    var Ent = _dbContext.RolePrivacies.SingleOrDefault(u => u.RoleId == rolePrivacyBEL.RoleId);
                    if (Ent!=null)
                    {
                        Ent.InstituteDelete = rolePrivacyBEL.InstituteDelete;
                        Ent.InstituteCreate = rolePrivacyBEL.InstituteCreate;
                        Ent.InstituteRead = rolePrivacyBEL.InstituteRead;
                        Ent.InstituteUpdate = rolePrivacyBEL.InstituteUpdate;

                        Ent.CampusCreate = rolePrivacyBEL.CampusCreate;
                        Ent.CampusDelete = rolePrivacyBEL.CampusDelete;
                        Ent.CampusRead = rolePrivacyBEL.CampusRead;
                        Ent.CampusUpdate = rolePrivacyBEL.CampusUpdate;

                        Ent.SchoolCreate = rolePrivacyBEL.SchoolCreate;
                        Ent.SchoolDelete = rolePrivacyBEL.SchoolDelete;
                        Ent.SchoolRead = rolePrivacyBEL.SchoolRead;
                        Ent.SchoolUpdate = rolePrivacyBEL.SchoolUpdate;

                        Ent.DepartmentCreate = rolePrivacyBEL.DepartmentCreate;
                        Ent.DepartmentDelete = rolePrivacyBEL.DepartmentDelete;
                        Ent.DepartmentRead = rolePrivacyBEL.DepartmentRead;
                        Ent.DepartmentUpdate = rolePrivacyBEL.DepartmentUpdate;

                        Ent.SemesterDelete = rolePrivacyBEL.SemesterDelete;
                        Ent.SemesterCreate = rolePrivacyBEL.SemesterCreate;
                        Ent.SemesterRead = rolePrivacyBEL.SemesterRead;
                        Ent.SemesterUpdate = rolePrivacyBEL.SemesterUpdate;

                        Ent.ProgramDelete = rolePrivacyBEL.ProgramDelete;
                        Ent.ProgramCreate = rolePrivacyBEL.ProgramCreate;
                        Ent.ProgramRead = rolePrivacyBEL.ProgramRead;
                        Ent.ProgramUpdate = rolePrivacyBEL.ProgramUpdate;

                        Ent.BatchCreate = rolePrivacyBEL.BatchCreate;
                        Ent.BatchDelete = rolePrivacyBEL.BatchDelete;
                        Ent.BatchRead = rolePrivacyBEL.BatchRead;
                        Ent.BatchUpdate = rolePrivacyBEL.BatchUpdate;

                        Ent.CourseDelete = rolePrivacyBEL.CourseDelete;
                        Ent.CourseDelete = rolePrivacyBEL.CourseDelete;
                        Ent.CourseRead = rolePrivacyBEL.CourseRead;
                        Ent.CourseUpdate = rolePrivacyBEL.CourseUpdate;

                        Ent.StudentCreate = rolePrivacyBEL.StudentCreate;
                        Ent.StudentDelete = rolePrivacyBEL.StudentDelete;
                        Ent.StudentRead = rolePrivacyBEL.StudentRead;
                        Ent.StudentUpdate = rolePrivacyBEL.StudentUpdate;

                        Ent.SectionCreate = rolePrivacyBEL.SectionCreate;
                        Ent.SectionDelete = rolePrivacyBEL.SectionDelete;
                        Ent.SectionUpdate = rolePrivacyBEL.SectionUpdate;
                        Ent.SectionRead = rolePrivacyBEL.SectionRead;


                        Ent.UserCreate = rolePrivacyBEL.UserCreate;
                        Ent.UserDelete = rolePrivacyBEL.UserDelete;
                        Ent.UserRead = rolePrivacyBEL.UserRead;
                        Ent.UserUpdate = rolePrivacyBEL.UserUpdate;

                        Ent.StudentUserCreate = rolePrivacyBEL.StudentUserCreate;
                        Ent.StudentUserDelete = rolePrivacyBEL.StudentUserDelete;
                        Ent.StudentUserRead = rolePrivacyBEL.StudentUserRead;
                        Ent.StudentUserUpdate = rolePrivacyBEL.StudentUserUpdate;

                        Ent.RoleCreate = rolePrivacyBEL.RoleCreate;
                        Ent.RoleDelete = rolePrivacyBEL.RoleDelete;
                        Ent.RoleRead = rolePrivacyBEL.RoleRead;
                        Ent.RoleUpdate = rolePrivacyBEL.RoleUpdate;


                        _dbContext.SaveChanges();

                        return new ResultModel()
                        {
                            Data = null,
                            Message = "Privacies have been updated successfully!",
                            Status = true
                        };



                    }
                    else
                    {
                        return new ResultModel()
                        {
                            Data = null,
                            Message = "Not Found in database",
                            Status = false
                        };
                    }
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

        public ResultModel SavePrivacyDAL(RolePrivacy rolePrivacy)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {
                    _dbContext.RolePrivacies.Add(rolePrivacy);
                    _dbContext.SaveChanges();

                    return new ResultModel()
                    {
                        Data = null,
                        Message = "Privacy applied successfully!",
                        Status = true
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

        public List<RolePrivacy> GetRolePrivaciesDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext() )
            {
                return _dbContext.RolePrivacies.ToList();
            }
        }

        public Role GetRoleById(int iD)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext ())
            {
                return _dbContext.Roles.SingleOrDefault(R => R.Id == iD);

            }
        }

        public ResultModel UpdateRoleDAL(Role _roleBEL)
        {

            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {
                    var UpdEnt = _dbContext.Roles.SingleOrDefault(R => R.Id == _roleBEL.Id);
                    if (UpdEnt != null)
                    {
                        UpdEnt.Id = _roleBEL.Id;
                        UpdEnt.Name = _roleBEL.Name;
                        UpdEnt.RoleTypeId = _roleBEL.RoleTypeId;

                        _dbContext.SaveChanges();

                        return new ResultModel
                        {
                            Data = null,
                            Message = "Role has been updated successfully",
                            Status = true
                        };

                    }
                    else
                    {
                        return new ResultModel
                        {
                            Data = null,
                            Message = "Role not found",
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

        public ResultModel DeleteRoleDAL(int id)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {
                    var DelEnt = _dbContext.Roles.SingleOrDefault(R => R.Id == id);
                    if (DelEnt != null)
                    {
                        _dbContext.Roles.Remove(DelEnt);
                        _dbContext.SaveChanges();

                        return new ResultModel
                        {
                            Data = null,
                            Message = "Role has been deleted successfully",
                            Status = true
                        };

                    }
                    else
                    {
                        return new ResultModel
                        {
                            Data = null,
                            Message = "Role not found",
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

        public object GetRolesDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Roles.Join(_dbContext.RoleTypes,
                    R => R.RoleTypeId,
                    r => r.Id,
                    (R, r) => new
                    {
                        Id = R.Id,
                        Name = R.Name,
                        RoleTypeId = r.Name

                    }


                    ).ToList();

            }
        }
    }
}
