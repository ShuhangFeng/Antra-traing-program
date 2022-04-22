using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6.inter;

namespace ConsoleApp6.datamodel
{
    public class Department: IDepartmentService
    {
        public List<Course> Courses { get; set; }

        public Instructor Lead { get; set; }

        public int Budget { get; set; }
    }
}
