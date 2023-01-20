using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OBE_BEL.Admin_Section.RolesBEL.RoleBEL;

namespace OBE_BEL.Admin_Section.RolesBEL.RolePrivacyBEL
{
    public class RolePrivacy
    {
        
        public Role Role { get; set; }
        [Key]
        [ForeignKey("Role")]
        public int RoleId { get; set; }

        //institute
        public bool InstituteRead { get; set; }   
        public bool InstituteCreate { get; set; }

        public bool InstituteUpdate { get; set; }
        public bool InstituteDelete { get; set; }

        //Campus
        public bool CampusRead{ get; set; }
        public bool CampusCreate { get; set; }

        public bool CampusUpdate { get; set; }
        public bool CampusDelete { get; set; }

        //School
        public bool SchoolRead { get; set; }
        public bool SchoolCreate { get; set; }

        public bool SchoolUpdate { get; set; }
        public bool SchoolDelete { get; set; }

        //Department
        public bool DepartmentRead { get; set; }
        public bool DepartmentCreate { get; set; }
        public bool DepartmentUpdate { get; set; }
        public bool DepartmentDelete { get; set; }

        //Semester
        public bool SemesterRead { get; set; }
        public bool SemesterCreate { get; set; }
        public bool SemesterUpdate { get; set; }
        public bool SemesterDelete { get; set; }

        //Program
        public bool ProgramRead { get; set; }
        public bool ProgramCreate { get; set; }
        public bool ProgramUpdate { get; set; }
        public bool ProgramDelete { get; set; }

        //Batch
        public bool BatchRead { get; set; }
        public bool BatchCreate { get; set; }
        public bool BatchUpdate { get; set; }
        public bool BatchDelete { get; set; }

        //Course
        public bool CourseRead { get; set; }
        public bool CourseCreate { get; set; }
        public bool CourseUpdate { get; set; }
        public bool CourseDelete { get; set; }

        //Student
        public bool StudentRead { get; set; }
        public bool StudentCreate { get; set; }
        public bool StudentUpdate { get; set; }
        public bool StudentDelete { get; set; }

        //Section
        public bool SectionRead { get; set; }
        public bool SectionCreate { get; set; }
        public bool SectionUpdate { get; set; }
        public bool SectionDelete { get; set; }


        //User
        public bool UserRead { get; set; }
        public bool UserCreate { get; set; }
        public bool UserUpdate { get; set; }
        public bool UserDelete { get; set; }

        //StudentUser
        public bool StudentUserRead { get; set; }
        public bool StudentUserCreate { get; set; }
        public bool StudentUserUpdate { get; set; }
        public bool StudentUserDelete { get; set; }

        //Role
        public bool RoleRead { get; set; }
        public bool RoleCreate { get; set; }
        public bool RoleUpdate { get; set; }
        public bool RoleDelete { get; set; }
    }
}
