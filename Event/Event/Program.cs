using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Program
    {
        delegate int Balance(ref int bal);
        class MyEvent
        {
            public event Balance MyBalance;
            public void RaiseEvent(ref int bal)
            {
                if(MyBalance!=null)
                {
                    MyBalance(ref bal);
                }
            }
        }
        class Deposit
        {
            public int DepositHandler(ref int amt)
            {
                Console.WriteLine("\n Depositing");
                return amt += 1000;
            }

        }
        class WithDraw
        {
            public int WithDrawHandler(ref int amt)
            {
                Console.WriteLine("\nWithDrawing");
                return amt -= 500;
            }
        }
        static void Main(string[] args)
        {
            MyEvent evt = new MyEvent();
            Deposit deposit = new Deposit();
            WithDraw withDraw = new WithDraw();
            evt.MyBalance += deposit.DepositHandler;
            int bal = 100;
            evt.RaiseEvent(ref bal);
            Console.WriteLine("Balance is" + bal);
            evt.MyBalance -= deposit.DepositHandler;
            evt.MyBalance += withDraw.WithDrawHandler;

            evt.RaiseEvent(ref bal);
            Console.WriteLine("Balance is" + bal);
            Console.ReadKey();

        }
    }
}
