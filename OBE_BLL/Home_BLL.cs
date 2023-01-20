using OBE_BEL.Admin_Section.RolesBEL.RoleBEL;
using OBE_BEL.Admin_Section.UserBEL;
using OBE_DAL;
namespace OBE_BLL
{
    public class Home_BLL
    {
        Home_DAL _homeDAL = new Home_DAL();

        public Role getRoleNameBLL(User loggedInUser)
        {
            return _homeDAL.getRoleNameDAL(loggedInUser);
        }

        public FacultyType getFacultyTypeBLL(User loggedInUser)
        {
            return _homeDAL.getFTypeDAL(loggedInUser);
        }
    }
}
