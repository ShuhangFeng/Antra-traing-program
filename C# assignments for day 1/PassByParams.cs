using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PassByParams
    {
        public void PassByReference(ref int x, ref int y)
        {
            Console.WriteLine($"{x}, {y}");
        }

        [Obsolete("use AddNumbers(params int[] arr) instead", true)]
        public int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }
        public int AddNumbers(params int[] arr)
        {
            int length = arr.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;

        }
    }

  
}
