using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02UnderstandingTypes
{
    public class Assignment2
    {

        //        Copying an Array
        //Write code to create a copy of an array.First, start by creating an initial array. (You can use
        //whatever type of data you want.) Let’s start with 10 items.Declare an array variable and
        //assign it a new array with 10 items in it.Use the things we’ve discussed to put some values
        //in the array.
        //Now create a second array variable.Give it a new array with the same length as the first.
        //Instead of using a number for this length, use the Lengthproperty to get the size of the
        //original array.
        //Use a loop to read values from the original array and place them in the new array.Also
        //print out the contents of both arrays, to be sure everything copied correctly
        Array CopyArray(int[] arr) {
            var result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[i]; }
            return result;
        }

        //        Write a simple program that lets the user manage a list of elements.It can be a grocery list,
        //"to do" list, etc.Refer to Looping Based on a Logical Expression if necessary to see how to
        //implement an infinite loop.Each time through the loop, ask the user to perform an
        //operation, and then show the current contents of their list.The operations available should
        //be Add, Remove, and Clear.The syntax should be as follows:
        //+ some item
        //- some item
        //--
        //Your program should read in the user's input and determine if it begins with a “+” or “-“ or
        //if it is simply “—“ . In the first two cases, your program should add or remove the string
        //given("some item" in the example). If the user enters just “—“ then the program should
        //clear the current list.

        void ManageList(List<String> list)
        {
            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                string entered = Console.ReadLine();
                if (entered.StartsWith("+"))
                {
                    list.Add(entered.Remove(0, 1));
                }
                else if (entered.StartsWith("-"))
                {
                    list.Remove(entered.Remove(0, 2));
                }
                else if (entered.StartsWith("--"))
                {
                    list.Clear();
                }
            }
        }
//        Write a method that calculates all prime numbers in given range and returns them as array
//of integers
        static int[] FindPrimesInRange(int startNum, int endNum)
        {
            List<int> list = new List<int>();
            
            for (int num = startNum; num <= endNum; num++)
            {
                int count = 0;

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0 && num != 1)
                {
                    list.Add(num);
                }
            }
            int[] result = new int[list.Count];
            for (int j = 0; j < list.Count(); j++)
            {
                result[j] = list[j];
            }
            return result;
        }

        //?
        //        Write a program to read an array of n integers(space separated on a single line) and an
        //integer k, rotate the array right k times and sum the obtained arrays after each rotation as
        //shown below.
        //After r rotations the element at position I goes to position (I + r) % n.
        //The sum[] array can be calculated by two nested loops: for r = 1 ... k; for I = 0 ... n-1.
        //Input Output Comments
        //3 2 4 -1 3 2 5 6 rotated1[] = -1 3 2 4
        //2 rotated2[] = 4 -1 3 2
        //sum[] = 3 2 5 6
        //1 2 3 4 5 12 10 8 6 9 rotated1[] = 5 1 2 3 4
        //3 rotated2[] = 4 5 1 2 3
        //rotated3[] = 3 4 5 1 2
        //sum[] = 12 10 8 6 9
        int[] RotateAndAdd()
        {
            int i, n;
            int[] a = new int[100];
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            return a;
        }

        //5. Write a program that finds the longest sequence of equal elements in an array of integers.
        //If several longest sequences exist, print the leftmost one.
        //Input Output
        //2 1 1 2 3 3 2 2 2 1 2 2 2
        //1 1 1 2 3 1 3 3 1 1 1
        //4 4 4 4 4 4 4 4
        //0 1 1 5 2 2 6 3 3 1 1
        int FindLongestElements(int[] numbers)
        {
            int count = 1;
            int longestNum = numbers[0];
            int longestCount = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[i - 1])
                {
                    count = 0;
                }

                count++;
                if (count > longestCount)
                {
                    longestCount = count;
                    longestNum = numbers[i];
                }

            }
            return longestNum;
        }

        //7. Write a program that finds the most frequent number in a given sequence of numbers.In
        //case of multiple numbers with the same maximal frequency, print the leftmost of them

        //        Write a program that reads a string from the console, reverses its letters and prints the
        //result back at the console.
        //Write in two ways
        //Convert the string to char array, reverse it, then convert it to string again
        //Print the letters of the string in back direction (from the last to the first) in a for-loop
        void RevertString1()
        {
            Console.WriteLine("Enter any word");
            string s = Console.ReadLine();
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string result = new string(charArray);
            Console.WriteLine(result);

        }

        void RevertString2()
        {
            Console.WriteLine("Enter any word");
            string s = Console.ReadLine();
            char[] charArray = s.ToCharArray();
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                Console.Write(charArray[i]);
            }

        }

        //        Write a program that reverses the words in a given sentence without changing the
        //punctuation and spaces
        //Use the following separators between the words: . , : ; = ( ) & [ ] " ' \ / ! ? (space).
        //All other characters are considered part of words, e.g.C++, a+b, and a77 are
        //considered valid words.
        //The sentences always start by word and end by separator
        public string ReverseWords(string str)
        {
            return String.Join(" ", str.Split('.', ' ', ',',':',';','=','(',')','&','[',']', '\\', '/', '!', '?').Reverse()).ToString();
        }

        //        Write a program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe”
        //and prints them on the console on a single line, separated by comma and space.Print all
        //unique palindromes (no duplicates), sorted
        void extractTextPalindromes(string text)
        {
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                if (this.isPalindrome(word)) {
                    Console.Write(word);
                }
            }
        }
        public Boolean isPalindrome(string S)
        {
            string st = S;
            char temp;
            int i = 0, j = st.Length - 1;
            while (j > i)
            {
                if (S[i] != S[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }


        //        Write a program that parses an URL given in the following format:
        //[protocol]://[server]/[resource]
        //The parsing extracts its parts: protocol, server and resource.
        //The[server] part is mandatory.
        //The[protocol] and[resource] parts are optional.
        //https://www.apple.com/iphone
        //[protocol] = "https"
        //[server] = "www.apple.com"
        //[resource] = "iphone"
        //ftp://www.example.com/employee
        //[protocol] = "ftp"
        //[server] = "www.example.com"
        //[resource] = "employee"
        //https://google.com
        //[protocol] = "https"
        //[server] = "google.com"
        //[resource] = ""
        //www.apple.com
        void parseURL(string url)
        {
            Regex r = new Regex(@"^(?<proto>\w+)://(?<server>:\w+)/(?<resource>:\w+)",
                          RegexOptions.None, TimeSpan.FromMilliseconds(150));
            Match m = r.Match(url);
            if(m.Success)
            {
                Console.WriteLine(m.Result("${proto} ${server} ${resource}"));
            }
        }
    }
}
