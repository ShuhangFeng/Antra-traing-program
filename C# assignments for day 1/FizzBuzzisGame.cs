using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02UnderstandingTypes
{
    public class FizzBuzzisGame
    { static void Main(String[] args)
        {

            //            FizzBuzzis a group word game for children to teach them about division.Players take turns
            //to count incrementally, replacing any number divisible by three with the word / fizz /, any
            //number divisible by five with the word / buzz /, and any number divisible by both with /
            //fizzbuzz /.
            //Create a console application in Chapter03 named Exercise03 that outputs a simulated
            //FizzBuzz game counting up to 100.The output should look something like the following
            //screenshot:
            //What will happen if this code executes?
            // answer: this will keeping printing since the range of byte is -255 to + 255
            //int max = 500;
            //for (byte i = 0; i < max; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //What code could you add(don’t change any of the preceding code) to warn us about the
            //problem?
            // answer: we can use obselete to stop user calling this method
            //Your program can create a random number between 1 and 3 with the following code:
            //int correctNumber = new Random().Next(3) + 1;
            //            Write a program that generates a random number between 1 and 3 and asks the user to
            //            guess what the number is.Tell the user if they guess low, high, or get the correct answer.
            //Also, tell the user if their answer is outside of the range of numbers that are valid guesses
            //(less than 1 or more than 3). You can convert the user's typed answer from a string to an
            //int using this code:
            void guessNumber() {
                int correctNumber = new Random().Next(3) + 1;
                Console.WriteLine("please enter a number between 1 and 3");
                int guessedNumber = int.Parse(Console.ReadLine());
                if (guessedNumber < 1 || guessedNumber > 3) {
                    Console.WriteLine("invalid guess");
                }
                else if (guessedNumber < correctNumber)
                {
                    Console.WriteLine("your guess is low");
                }
                else if (guessedNumber > correctNumber)
                {
                    Console.WriteLine("your guess is low");
                }
                else
                {
                    Console.WriteLine("your guess is correct!");
                }
            }

            //Write a simple program that defines a variable representing a birth date and calculates
            //how many days old the person with that birth date is currently.
            //For extra credit, output the date of their next 10,000 day(about 27 years) anniversary.
            //Note: once you figure out their age in days, you can calculate the days until the next
            //anniversary using int daysToNextAnniversary = 10000 - (days % 10000); .
            void DaysOld(DateTime birthday)
            {
                TimeSpan diff = DateTime.Now.Subtract(birthday);
                double day = diff.TotalDays;
                Console.WriteLine($" days old the person with that birth date is {day}");
            }

            //Write a program that greets the user using the appropriate greeting for the time of day.

            //Use only if , not else or switch , statements to do so.Be sure to include the following
            //greetings:
            //        "Good Morning"
            //        "Good Afternoon"
            //        "Good Evening"
            //        "Good Night"
            //        It's up to you which times should serve as the starting and ending ranges for each of the
            //        greetings.If you need a refresher on how to get the current time, see DateTime
            //        Formatting.When testing your program, you'll probably want to use a DateTime variable
            //        you define, rather than the current time. Once you're confident the program works
            //        correctly, you can substitute DateTime.Now for your variable (or keep your variable and just
            //        assign DateTime.Now as its value, which is often a better approach).
            void Greetings(DateTime currentTime)
            {
                int hour = currentTime.Hour;
                StringBuilder greetings = new StringBuilder("");
                if (4 < hour && hour <13)
                {
                    greetings = greetings.Insert(0, "Good Morning");
                }
                if (12 < hour && hour < 17)
                {
                    greetings = greetings.Insert(0, "Good Afternoon");
                }
                if (16 < hour && hour < 21)
                {
                    greetings = greetings.Insert(0, "Good Evening");
                }
                if (20 < hour || hour < 5)
                {
                    greetings = greetings.Insert(0, "Good Night");
                }
                String a = greetings.ToString();

                Console.WriteLine($" {a}");
            }
            //Greetings(DateTime.Now);

            //            Write a program that prints the result of counting up to 24 using four different increments.
            //First, count by 1s, then by 2s, by 3s, and finally by 4s.
            //                Use nested for loops with your outer loop counting from 1 to 4.You inner loop should
            //                count from 0 to 24, but increase the value of its / loop control variable / by the value of the /
            //                loop control variable / from the outer loop.This means the incrementing in the /
            //                afterthought / expression will be based on a variable.
            //                Your output should look something like this:
            //                0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24
            //                0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24
            //                0, 3, 6, 9, 12, 15, 18, 21, 24
            //                0, 4, 8, 12, 16, 20, 24
            void countNumbers()
            {
                StringBuilder s1 = new StringBuilder("");
                StringBuilder s2 = new StringBuilder("");
                StringBuilder s3 = new StringBuilder("");
                StringBuilder s4 = new StringBuilder("");
                for (int i = 0; i < 24; i++)
                {
                    s1.Append(i);
                    s1.Append(",");

                    if (i % 2 == 0)
                    {
                        s2.Append(i);
                        s2.Append(",");
                    }

                    if (i  % 3 == 0)
                    {
                        s3.Append(i);
                        s3.Append(",");
                    }

                    if (i % 4 == 0)
                    {
                        s4.Append(i);
                        s4.Append(",");
                    }
                }
                Console.WriteLine(s1);
                Console.WriteLine(s2);
                Console.WriteLine(s3);
                Console.WriteLine(s4);
            }
            //countNumbers();



        }
        }
}
