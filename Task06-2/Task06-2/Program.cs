using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "икосаэдр";
            var word1 = s
                .Remove(5)
                .Remove(2, 2)
                .Remove(0, 1);

            word1 += s.Substring(6);

            Console.WriteLine(word1);

            var word2 = s
                .Remove(5)
                .Remove(2, 2)
                .Remove(0, 1);
            
            word2 += ReverseString(s
                .Remove(5, 2)
                .Remove(0, 3));

            word2 += s.Substring(0, 2);

            Console.WriteLine(word2);        

            Console.ReadKey();
        }

        static string ReverseString(string s)
        {
            return new string(s.Reverse().ToArray());
        }
    }
}
