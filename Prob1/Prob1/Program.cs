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
            Console.WriteLine("What service do u want ? Press 1 for Deposit or 2 for Withdraw.");

            int result;

            if (int.TryParse(Console.ReadLine(), out result))
            {

                if (result == 1)
                {
                    Console.WriteLine("Well, Please enter your money: ");
                    string str = Console.ReadLine();
                    int a = Convert.ToInt32(str);
                    Console.WriteLine("Your money: {0}", a);

                }

                else if (result == 2)
                {
                    Console.WriteLine("Well, Please enter your money: ");
                    string str1 = Console.ReadLine();
                    int a = Convert.ToInt32(str1);
                    Console.WriteLine("Your money: {0}", a);
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


 

