using System;
using System.Collections.Generic;
using OBE_BEL;
using OBE_BEL.Assessment_Section;
using OBE_BEL.MyInstitute_Section;
using OBE_BEL.MyInstitute_Section.DepartmentBEL;
using OBE_BEL.ViewModels;
using OBE_DAL.MyInstitute_DAL;

namespace OBE_BLL.MyInstitute_BLL
{
    public class DepartmentBLL
    {
        Department_DAL _departmentDAL = new Department_DAL();
        
        //Create
        public ResultModel CreateDepartmentBLL(Department _departmentBEL)
        {
            return _departmentDAL.CreateDepartmentDAL(_departmentBEL);
        }

        //Delete
        public ResultModel DeleteDepartmentBLL(int iD)
        {
            return _departmentDAL.DeleteDepartmentDAL(iD);
        }

        //Update

        public ResultModel UpdateDepartmentBLL(Department _departmentBEL)
        {
            return _departmentDAL.UpdateDepartmentDAL(_departmentBEL);
        }

        //Read
        public List<AssessmentMethod> GetAssessmentMethodsBLL()
        {
            return _departmentDAL.GetAssessmentMethodsDAL();
        }

        public List<GPA_Method> GetGPAMethodsBLL()
        {
            return _departmentDAL.GetGPAMethodsDAL();
        }

        public List<VM_DepartmentSchool> GetDepartmentsBLL()
        {
            return _departmentDAL.GetDepartmentsDAL();
        }

        public Department GetDepartmentByIdBLL(int iD)
        {
            return _departmentDAL.GetDepartmentByIdDAL(iD);
        }

        public List<VM_DepartmentSchool> FilterByNameBLL(string text)
        {
            return _departmentDAL.FilterByNameDAL(text);
        }

        public List<VM_DepartmentSchool> FilterBySchoolBLL(int v)
        {
            return _departmentDAL.FilterBySchoolDAL(v);
        }

        public int CountDepartments()
        {
            return _departmentDAL.CountDepartDAL();
        }
    }
}
