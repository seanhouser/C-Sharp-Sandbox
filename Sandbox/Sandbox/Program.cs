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
            int[] arr1 = { 1, 3, -5, 4 };
            int[] arr2 = { 1, 4, -5, -2 };
            Console.WriteLine(String.Join(",", mul_arrays(arr1, arr2)));
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
