using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            Console.WriteLine("welcome to ATM");
            Console.WriteLine("ENTER YOUR 4 Digit PIN");
            string pin = Console.ReadLine();
            int num = Convert.ToInt32(pin.Length);
            while (true)
            {

                if (num == 4)
                {
                    Console.WriteLine("1. Check Balance");
                    Console.WriteLine("2. Deposite");
                    Console.WriteLine("3. Widthrwal");
                    Console.WriteLine("ENTER OPTION");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            atm.CHECKBALANCE();
                            break;
                        case 2:
                            atm.CheckDeposit();
                            atm.CHECKBALANCE();
                            break;
                        case 3:
                            atm.CheckWidthrwal();
                            atm.CHECKBALANCE();
                            break;
                        default:
                            Console.WriteLine("INVALID INPUT");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("please enter the 4 digit pin");
                }

            }
        }
    }
}







