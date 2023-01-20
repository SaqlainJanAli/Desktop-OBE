using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBE_BEL.ViewModels
{
    public class VM_SchoolCampusCity
    {

        public int Id { get; set; }
        public string Icon_Path { get; set; }
        public string Name { get; set; }
        public string CampusId { get; set; }
        public string CityId { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
    }
}
