using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter numbers");
            string s = Console.ReadLine();
            Console.WriteLine("enter the number to be counted");
            string number = Console.ReadLine();
            Console.WriteLine("Your number, {0}, was counted {1} times", number, count_number_repeat(number, s));
        }

        //count a specified number in a given array of integers
        public static int count_number_repeat(string number, string s)
        {
            int count = 0;
            string[] nums = s.Split(' ');
            foreach (string num in nums)
            {
                if (num == number)
                    ++count;
            }
            return count;
        }

        //create a new string of every other character (odd position) from the first position of a given string
        public static string odd_chars(string s)
        {
            string result = "";
            for (int i = 0; i < s.Length; i += 2)
            {
                result += s[i];
            }
            return result;
        }

        /* create a new string where the first 4 characters will be in lower case. If the string is less than 4 characters then make the whole              string in upper case
         * */
        public static string to_caps(string s)
        {
            string result = "";
            if (s.Length >= 4)
            {
                string front = s.ToLower();
                result = front.Substring(0, 4) + s.Substring(4, s.Length-4);
            }
            else
            {
                result = result.ToUpper();
            }
            return result;
        }

        public static bool check_1to3_w(string s)
        {
            int count = 0;
            foreach (var c in s)
            {
                if (c == 'w' || c == 'W')
                    ++count;
            }
            return (count >= 1 && count <= 3);
        }

        //check the nearest value of 20 of two given integers and return 0 if two numbers are same
        public static int near_20(int first, int second)
        {
            int first_diff = Math.Abs(first - 20);
            int second_diff = Math.Abs(second - 20);
            if (first == second)
                return 0;
            else if (first_diff < second_diff)
                return first;
            else
                return second;
        }

        //find the largest and lowest values from three integer values
        public static void largest_lowest(int first, int second, int third)
        {
            int[] nums = {first, second, third};
            int largest = first;
            int smallest = first;
            for (int i = 0; i < nums.Length; ++i)
            {
                if (nums[i] > largest)
                    largest = nums[i];
                if (nums[i] < smallest)
                    smallest = nums[i];
            }
            Console.WriteLine("Largest: {0}\nSmallest: {1}", largest, smallest);
        }

        /*get a new string of two characters from a given string. The first and second character of the given string must be "P" and "H", so PHP            will be "PH".
         * */
        public static string second_first_PH(string s)
        {
            string result = s.Substring(1, 2);
            if (result == "PH")
                return result;
            else
                return s;
        }

        //check if "HP" appears at second position in a string and returns the string without "HP"
        public static bool check_HP(string s)
        {
            return (s.Substring(1, 2) == "HP");
        }

        //Check if both numbers are in the range -10..10
        public static bool in_range(int first, int second)
        {
            return (first < 10 && first > -10 && second < 10 && second > -10);
        }

        //Check if the first number is <100 and the second number is >250
        public static bool check_numbers(int first, int second)
        {
            return (first < 100 && second > 250);
        }

        //Check if first word matches param
        public static bool check_first(string s, string word)
        {
            return (s.Substring(0, word.Length) == word);
        }

        //Check if int is multiple of 3 or 7
        public static bool multiple_3_7(int n)
        {
            return (n % 3 == 0 || n % 7 == 0);
        }

        //Exrracy last four of a string and repeat
        public static void extract_four(string s)
        {
            if (s.Length >= 4)
                Console.WriteLine("{0}{1}{2}{3}", s.Substring(s.Length - 4, 4), s.Substring(s.Length - 4, 4), s.Substring(s.Length - 4, 4), s.Substring(s.Length - 4, 4));
            else
                Console.WriteLine(s);

            /*
             * OR
             *  string extracted = s.Substring(s.Length - 4, 4);
                if (s.Length >= 4)
                    Console.WriteLine("{0}{1}{2}{3}", extracted, extracted, extracted, extracted);
                else
                    Console.WriteLine(s);
             */
        }

        //Multiple corresponding elements of two arrays
        public static int[] mul_arrays(int[] arr1, int[] arr2)
        {
            int[] arr_result = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; ++i)
            {
                arr_result[i] = arr1[i] * arr2[i];
            }
            return arr_result;
        }

        //String reverse by word
        public static string word_reverse(string s)
        {
            string result = "";
            string[] words = s.Split(' ');
            for (int i = words.Count()-1; i >= 0; --i)
            {
                result += words[i];
                result += " ";
            }
            return result;
        }

        //Sum of digits of an integer
        public static int digit_sum(int n)
        {
            int sum = 0;
            String num_string = n.ToString();
            foreach (var c in num_string)
                sum += c-48;

            return sum;

            /* OR
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n != 0) {
            sum += n % 10;
            n /= 10;
            Console.WriteLine("Sum of the digits of the said integer: " + sum);
            */
        }

        //Sum of all primes from 0-500
        public static int prime_sum()
        {
            int sum = 0;
            for (int i = 2; i <= 500; i++)
            {
                if (is_prime(i))
                    sum += i;
                //Console.WriteLine("The number {0} is prime: {1}", i, Convert.ToString(is_prime(i)));
            }
            return sum;
        }

        //Returns true if prime
        public static bool is_prime(int n)
        {
            bool result = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    result = false;
            }
            return result;
        }

        //Prints odd numbers from 1-100
        public static void print_odds()
        {
            for (int i = 1; i <= 100; i += 2)
                Console.WriteLine(i);
        }

        //Returns largest word in string
        public static string get_largest(string s)
        {
            string[] words = s.Split(' ', '.');
            int largest_size = words[0].Length;
            int largest_index = 0;
            for (int i = 0; i < words.Count(); i++)
            {
                if (words[i].Length > largest_size)
                {
                    largest_size = words[i].Length;
                    largest_index = i;
                }
            }
            return words[largest_index];
        }

        //Flips first and last letters of a string
        public static string flip(string ustr)
        {
            if (ustr.Length > 0)
                return ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1);
            else
                return ustr;
        }

        //Adds the first character of a string to the beginning and end of the string
        public static string append(string ustr)
        {
            return ustr.Length > 0
                ? ustr.Substring(0, 1) + ustr + ustr.Substring(0, 1) : ustr;
        }

        //Returns true only if one of the passed integers is pos and the other is neg
        public static bool neg_pos_check(int n, int m)
        {
            return n > 0 && m < 0 || n < 0 && m > 0
                ? true : false;
        }

        //Returns the sum of two ints, or 3*sum if the ints are equal
        public static int double_nums(int n, int m)
        {
            return n == m
                ? 3 * (n + m) : n + m;
        }
    }
}
