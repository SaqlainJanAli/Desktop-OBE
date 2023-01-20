using System.Collections.Generic;
using OBE_BEL;
using OBE_BEL.Admin_Section.RolesBEL.RoleBEL;
using OBE_BEL.Admin_Section.RolesBEL.RolePrivacyBEL;
using OBE_DAL.Admin_DAL;

namespace OBE_BLL.AdminSection_BLL
{
    public class Role_BLL
    {
        Role_DAL _roleDAL = new Role_DAL();

        public object GetRoleTypes()
        {
            return _roleDAL.GetRoleTypesDAL();
        }

        public ResultModel CreateRoleBLL(Role _roleBEL)
        {
            return _roleDAL.CreateRoleDAL(_roleBEL);
        }

        public object GetRolesBLL()
        {
            return _roleDAL.GetRolesDAL();
        }

        public ResultModel DeleteRoleBLL(int id)
        {
            return _roleDAL.DeleteRoleDAL(id);
        }

        public ResultModel UpdateRoleBLL(Role _roleBEL)
        {
            return _roleDAL.UpdateRoleDAL(_roleBEL);
        }

        public Role GetRoleByIdBLL(int iD)
        {
            return _roleDAL.GetRoleById(iD);
        }

        public List<RolePrivacy> GetRolePrivaciesBLL()
        {
            return _roleDAL.GetRolePrivaciesDAL();
        }

        public ResultModel UpdatePrivacyBLL(RolePrivacy rolePrivacyBEL)
        {
            return _roleDAL.UpdatePrivacyDAL(rolePrivacyBEL);
        }

        public ResultModel SavePrivacyBLL(RolePrivacy rolePrivacy)
        {
            return _roleDAL.SavePrivacyDAL(rolePrivacy);
        }
    }
}
