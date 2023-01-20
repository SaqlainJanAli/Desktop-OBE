using System.Linq;
using OBE_BEL.Admin_Section.RolesBEL.RoleBEL;
using OBE_BEL.Admin_Section.UserBEL;

namespace OBE_DAL
{
    public class Home_DAL
    {
        public Role getRoleNameDAL(User loggedInUser)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.Roles.Where(r => r.Id== loggedInUser.RoleId).SingleOrDefault();

            }
        }

        public FacultyType getFTypeDAL(User loggedInUser)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext ())
            {

                var Ent = _dbContext.FacultyUsers.Where(f => f.UserId == loggedInUser.Id).SingleOrDefault();
                if (Ent != null)
                {
                    return _dbContext.FacultyTypes.Where(f => f.Id == Ent.FacultyTypeId).SingleOrDefault();


                }
                else
                {
                    return null;
                }
            }
        }
    }
}
