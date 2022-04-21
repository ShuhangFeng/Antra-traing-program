using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02UnderstandingTypes
{
    public class CenturiesConverter
    {
        public void CenturiesConverterFunc(uint centuries)
        {
            long year = 100 * centuries;
            long day = 36524 * centuries;
            long hour = 876576 * centuries;
            long minute = 52594560 * centuries;
            long second = 3155673600 * centuries;
            long milliseconds = 3155673600000 * centuries;
            long microseconds = 3155673600000000 * centuries;
            long nanoseconds = 3155673600000000000 * centuries;
            Console.WriteLine($"centuries = {year} years = {day} days = {hour} hours = " +
                $"{minute} minutes = {second} seconds = {milliseconds} milliseconds = {microseconds}" +
                $"microseconds = {nanoseconds} nanoseconds");
        }
    }
}
