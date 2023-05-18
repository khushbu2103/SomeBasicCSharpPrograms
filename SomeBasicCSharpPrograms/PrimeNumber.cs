using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeBasicCSharpPrograms
{
    internal class PrimeNumber
    {
        public static void PrimeNumb(int num)
        {
            int factorCount = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    factorCount++;
                }
            }
            if (factorCount == 2)
            {
                Console.WriteLine("{0} is prime number", num);
            }
            else
            {
                Console.WriteLine("{0} is not prime number", num);
            }
        }
        public static void PrimeNumbWithinRange(int maxnum)
        {
            int factorCount = 0;
            for (int j = 2; j <= maxnum; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    if (j % i == 0)
                    {
                      factorCount++;
                    }
                    if (factorCount > 0)
                        break;
                }
                if (factorCount == 2)
                {
                    Console.WriteLine("{0} is prime number", j);
                }
                else
                {
                    Console.WriteLine("{0} is not prime number", j);
                }
            }
            Console.ReadLine();
        }
       
    }
}
