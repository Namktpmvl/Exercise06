using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What service do u want ? Press 1 for Deposit or 2 for Withdraw or 3 to check your money");

            int result;

            if (int.TryParse(Console.ReadLine(), out result))
            {

                if (result == 1)
                {
                    Account acc = new Account(200000);
                    Console.WriteLine("Well, Please enter your money you want to deposit: ");
                    string str = Console.ReadLine();
                    int a = Convert.ToInt32(str);
                    acc.Deposit(a);
                    

                }

                else if (result == 2)
                {
                    Account acc = new Account(200000);
                    Console.WriteLine("Well, Please enter your money: ");
                    string str1 = Console.ReadLine();
                    int a = Convert.ToInt32(str1);
                    acc.Withdraw(a);
                    
                }

                else if (result ==3)
                {

                    Account acc = new Account(200000);
                    acc.balance();
                }
                else

                    Console.WriteLine("Incorrect response");
            }

            else

                Console.WriteLine("Incorrect response");

            Console.ReadLine();
        }
    }
}


 

