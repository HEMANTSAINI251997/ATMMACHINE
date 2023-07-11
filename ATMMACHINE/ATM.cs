using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class ATM
    {
        int balance = 5000;
        int withdrwal = 0;
        int amount = 0;
        public void CHECKBALANCE()
        {
            Console.WriteLine("YOUR BALANCE = " + balance);
        }
        public void CheckWidthrwal()
        {
            if (balance == 0)
            {
                Console.WriteLine("NO BALANCE AVAILABLE");

            }
            else
            {
                Console.WriteLine("ENTER THE AMOUNT");
                amount = Convert.ToInt32(Console.ReadLine());
                if (amount > balance)
                {
                    Console.WriteLine("Insufficient balance. Unable to perform withdrawal.");
                }
                else
                {
                    withdrwal = amount;
                    balance -= amount;
                    Console.WriteLine("Withdrawal Successful");
                }
            }
        }
        public void CheckDeposit()
        {
            Console.WriteLine("ENTER THE AMOUNT TO DEPOSIT");
            amount = Convert.ToInt32(Console.ReadLine());
            balance += amount;
            Console.WriteLine("Deposit Successful");
        }

    }
}
