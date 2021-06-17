using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.ViewModel
{
    public class SubjectCreateViewModel
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public Guid ClassId { get; set; }
        public Guid TeacherId { get; set; }
    }

    public class SubjectListViewModel
    {
        public Guid SubjectId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Class { get; set; }
        public string Teacher { get; set; }
    }
}