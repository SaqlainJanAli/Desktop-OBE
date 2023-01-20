using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBE_BEL.ViewModels
{
    public class VM_InstituteCountryCity
    {
        public int Id { get; set; }
        public string Logo_Path { get; set; }
        public string Name { get; set; }
        public string IssuingAuthorityId { get; set; }
        public string InstituteTypeId { get; set; }
        public int FullGPA { get; set; }
        public string WebsiteURL { get; set; }
    }
}
