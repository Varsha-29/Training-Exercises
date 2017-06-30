using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class DelegateTest
    {
        delegate string StrMod(string s);
        static string ReplaceSpaceWithHypens(string s)
        {
            return s.Replace(" ", "-");

        }
        static string Reverse(string s)
        {
            int length = s.Length;
            string temp = "";
            int i = length - 1, j = 0;
            for (; i >= 0; i--, j++)
            {
                temp += s[i];
            }
            return temp;
        }
        static void Main(string[] args)
        {
            StrMod obj = Reverse;
            string s = obj("Reversing a string");
            Console.WriteLine(s);
            obj = ReplaceSpaceWithHypens;
            s = obj("Replace space with hypens");
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
