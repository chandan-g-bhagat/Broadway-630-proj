using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.ViewModel
{
    public class ClassCreateViewModel
    {
        public string Name { get; set; }
        public string RoomNumber { get; set; }
        public Guid Teacherid { get; set; }
    }
}