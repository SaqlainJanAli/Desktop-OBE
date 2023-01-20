using System.Collections.Generic;
using OBE_BEL;
using OBE_BEL.Admin_Section.RolesBEL;
using OBE_BEL.Admin_Section.RolesBEL.RolePrivacyBEL;
using OBE_BEL.Admin_Section.UserBEL;
using OBE_DAL.Admin_DAL;

namespace OBE_BLL.AdminSection_BLL
{
    public class User_BLL
    {
        User_DAL _userDAL = new User_DAL();

        public List<Gender> GetGendersBLL()
        {
           return _userDAL.getGendersDAL();
        }

        public List<FType> GetFTypesBLL()
        {
            return _userDAL.getFTypesDAL();
        }

        public List<FacultyType> GetFacultyTypesBLL()
        {
            return _userDAL.getFacultyTypesDAL();
        }

        public object GetUsersBLL()
        {
            return _userDAL.GetUsersDAL();
        }

        public ResultModel CreateUserBLL(User _userBEL)
        {
            return _userDAL.CreateUserDAL(_userBEL);
        }

        public ResultModel CreateFacultyBLL(FacultyUser _facultyUserBEL)
        {
            return _userDAL.CreateFacultyDAL(_facultyUserBEL);
        }

        public object GetFacultiesBLL()
        {
            return _userDAL.GetFacultiesDAL();
        }

        public User getUserByIdBLL(int id)
        {
            return _userDAL.GetUserByIdDAL(id);
        }

        public FacultyUser getFacultyByIdBLL(int id)
        {
            return _userDAL.GetFacultyByIdDAL(id);
        }

        public ResultModel DeleteUserBLL(int id)
        {
            return _userDAL.DeleteUserDAL(id);
        }

        public ResultModel UpdateFacultyBLL(FacultyUser _facultyUserBEL)
        {
            return _userDAL.UpdateFacultyDAL(_facultyUserBEL);
        }

        public ResultModel UpdateUserBLL(User _userBEL)
        {
            return _userDAL.UpdateUserDAL(_userBEL);
        }

        public List<User> GetEmailsBLL()
        {
            return _userDAL.getEmailsDAL();
        }

        public object FilterByEmailBLL(string text)
        {
            return _userDAL.FilterByEmailDAL(text);
        }

        public object FilterByisActiveBLL(bool @checked)
        {
            return _userDAL.FilterByisActiveDAL(@checked);
        }

        public User getUserByEmailBLL(string text)
        {
            return _userDAL.getuserByEmailDAL(text);
        }

        public object FilterByRoleBLL(int v)
        {
            return _userDAL.FilterByRoleDAL(v);
        }

        public RolePrivacy getPrivacyByIdBLL(int roleId)
        {
            return _userDAL.getPrivacyByIdDAL(roleId);
        }

        public object CountUsersBLL()
        {
            return _userDAL.CountUsersDAL();
        }
    }
}
