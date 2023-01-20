using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBE_BEL.ViewModels
{
    public class VM_DepartmentSchool
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo_Path { get; set; }
        public string SchoolId { get; set; }
        public int Attendance { get; set; }
        public string AssessmentMethodId { get; set; }
        public bool isActive { get; set; }
        public string GpaMethodId { get; set; }
    }
}
