using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6.inter;

namespace ConsoleApp6.datamodel
{
    public class Person: IPersonService
    {
        public int BornYear { get; set; }
        private decimal salary;
        public virtual decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Only positive values are allowed");

                Salary = value;
            }
        }

        public List<string> Addresses { get; set; }
        public Department Department { get; set; }
    }
}
