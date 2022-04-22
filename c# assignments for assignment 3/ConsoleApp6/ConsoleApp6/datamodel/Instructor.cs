using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6.inter;

namespace ConsoleApp6.datamodel
{
    public class Instructor: Person, IInstructorService
    {
        public decimal bonus { get; set; }
        public override decimal Salary
        {
            get { return base.Salary; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Only positive values are allowed");

                Salary = value + bonus;
            }
        }
    }
}
