using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class MathProblems
    {

        //        Let’s make a program that uses methods to accomplish a task.Let’s take an array and
        //reverse the contents of it.For example, if you have 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, it would
        //become 10, 9, 8, 7, 6, 5, 4, 3, 2, 1.
        //To accomplish this, you’ll create three methods: one to create the array, one to reverse the
        //array, and one to print the array at the end.
        //Your Mainmethod will look something like this:
        //static void Main(string[] args)
        //        {
        //            int[] numbers = GenerateNumbers();
        //            Reverse(numbers);
        //            PrintNumbers(numbers);
        //        }
        //        The GenerateNumbersmethod should return an array of 10 numbers. (For bonus points,
        //        change the method to allow the desired length to be passed in, instead of just always
        //        being 10.)
        //The PrintNumbersmethod should use a foror foreachloop to print out each item in the
        //array.The Reversemethod will be the hardest.Give it a try and see what you can make
        //happen.If you get
        //stuck, here’s a couple of hints:
        //Hint #1:To swap two values, you will need to place the value of one variable in a temporary
        //location to make the swap:
        //// Swapping a and b.
        //int a = 3;
        //        int b = 5;
        //        int temp = a;
        //        a = b;
        //b = temp;
        //Hint #2:Getting the right indices to swap can be a challenge. Use a forloop, starting at 0
        //and going up to the length of the array / 2. The number you use in the forloop will be the
        //index of the first number to swap, and the other one will be the length of the array minus
        //the index minus 1. This is to account for the fact that the array is 0-based.So basically,
        //you’ll be swapping array[index]with array[arrayLength – index – 1]
        static void main(string[] args)
        {
            int[] numbers = generatenumbers();
            reverse(numbers);
            printnumbers(numbers);
        }

        static int[] generatenumbers()
        {
            int Min = 0;
            int Max = 100;
            int[] result = new int[10];

            Random randNum = new Random();
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = randNum.Next(Min, Max);
            }
            return result;

        }
        static void reverse(int[] numbers)
        {
            int i = 0;
            int j = numbers.Length - 1;
            int temp;
            for (; i < j; i++, j--) {
                temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;

            }
        }

        public static void printnumbers(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        //The Fibonacci sequence is a sequence of numbers where the first two numbers are 1 and 1,
        //    and every other number in the sequence after it is the sum of the two numbers before it.So
        //    the third number is 1 + 1, which is 2. The fourth number is the 2nd number plus the 3rd,
        //    which is 1 + 2. So the fourth number is 3. The 5th number is the 3rd number plus the 4th
        //    number: 2 + 3 = 5. This keeps going forever.
        //    The first few numbers of the Fibonacci sequence are: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, ...
        //    Because one number is defined by the numbers before it, this sets up a perfect
        //    opportunity for using recursion.
        //    Your mission, should you choose to accept it, is to create a method called Fibonacci, which
        //    takes in a number and returns that number of the Fibonacci sequence.So if someone calls
        //    Fibonacci(3), it would return the 3rd number in the Fibonacci sequence, which is 2. If
        //    someone calls Fibonacci(8), it would return 21.
        public static int Fibonacci(int num)
        {
            int a = 0, b = 1, c = 0, result = 0;
            for (int i = 0; i < num; i++)
            {
                result = a;
                c = a + b;
                a = b;
                b = c;
            }
            return result;
        }
    }
}
