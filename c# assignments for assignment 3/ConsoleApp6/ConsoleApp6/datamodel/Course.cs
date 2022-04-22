using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6.inter;

namespace ConsoleApp6.datamodel
{
    public class Course: ICourseService
    {   
        public Grade Grade { get; set; }

        public List<string> Students { set; get; }
    }

    public enum Grade
    {
        A = 4,B = 3,C = 2,D = 1,F = 0
    }
}
