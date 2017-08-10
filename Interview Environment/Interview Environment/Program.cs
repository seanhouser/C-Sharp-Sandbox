using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Environment
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "I like to walk my dog";
            Console.WriteLine(Convert.ToString(
        }

        public static string[] separate(string s)
        {
            string temp;
            for (int i = 0; i < s.Length; ++i)
            {
                temp += s[i];
                if (s[i + 1] == " ")
                {
                    arr1 += temp;
                    temp = "";
                }
            }
        }

    }
}
