using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OBE_BEL.Admin_Section.RolesBEL;
using OBE_BEL.MyInstitute_Section.DepartmentBEL;

namespace OBE_BEL.Admin_Section.UserBEL
{
    public class FacultyUser
    {
        [Key]
        public int Id { get; set; }

        public string MiddleName { get; set; }

        //public Type MyProperty { get; set; }
        public FType FType { get; set; }
        [ForeignKey("FType")]
        public int FTypeId { get; set; }

        public string Designation { get; set; }

        public Gender Gender { get; set; }
        [ForeignKey("Gender")]
        public int GenderId { get; set; }

        public FacultyType FacultyType { get; set; }
        [ForeignKey("FacultyType")]
        public int FacultyTypeId { get; set; }

        public bool Active { get; set; }

        public bool Ph_D { get; set; }

        public string CNIC { get; set; }

        public DateTime JoiningDate { get; set; }
        public DateTime LeavingDate { get; set; }

        public string MobileNo { get; set; }

        public Department Department{ get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public User User { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
    }

}
