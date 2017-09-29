//AUTHOR: Sean Houser
//DATE: 9/12/2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCheck
{
    class Program
    {
        //Checks to see if a provided string is a palindrome. Empty and single-character strings are palindromes.
        static void Main(string[] args)
        {
            bool is_palindrome = true;      //boolean for storing and presenting result

            //Request and store the string the be checked as a palindrome
            Console.WriteLine("Please enter the string you would like checked as a palindrome\n");
            string palindrome_string = Console.ReadLine();

            //Check for palindrome by comparing the original and the reversed string
            if (reverse_string(palindrome_string) == palindrome_string)
                is_palindrome = true;
            else
                is_palindrome = false;

            //Output results
            Console.WriteLine("The result of checking if your string, {0}, is a palindrome is: {1}\n", palindrome_string, is_palindrome);
        }

        //IN: string to be reversed
        //OUT: reversed string to be used for palindrome check
        public static string reverse_string(string palindrome_string)
        {
            string reverse_string = "";     //string for storing and returning the reversed string

            //Convert the string to a character array, then iterate over the array from back to front, storing each character in the return string
            char[] char_array_of_string = palindrome_string.ToCharArray();
            for (int i = char_array_of_string.Length - 1; i >= 0; --i)
                reverse_string += char_array_of_string[i];

            return reverse_string;
        }
    }
}