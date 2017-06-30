using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegation
{
    class Program
    {
        delegate int IntOper(ref int a, ref int b);
        static int Add(ref int a, ref int b)
        {
            Console.WriteLine("Adding");
            b += 10;
            return a + b;
        }
        static int Mul(ref int a,ref int b)
        {
            Console.WriteLine("Multiplying");
            return a * b;
        }
        static int Div(ref int a,ref int b)
        {
            Console.WriteLine("\n Dividing");
            if (a > b)
                return a / b;
            else
                return b / a;
        }
        static void Main(string[] args)
        {
            IntOper invoker;
            IntOper addOper = Add;
            IntOper MulOper = Mul;
            IntOper DivOper = Div;
            invoker = Add;
            invoker += Mul;
            int a = 947, b = 60;
            int c=invoker(ref a, ref b);
            Console.WriteLine(c);
            invoker -= Mul;
            c = invoker(ref a, ref c);
            Console.WriteLine(c);
            invoker += Div;
            c = invoker(ref a, ref c);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
