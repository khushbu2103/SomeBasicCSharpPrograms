using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeBasicCSharpPrograms
{
    internal class FibonoccieSeries
    {
        public static void Generatefibinoccienumb(int n)
        {
            int numb1 = 0, numb2 = 1, sum = 0;
            //Console.Write(numb1 + " " + numb2);
            // Console.Write("{0} {1}",numb1,numb2);
            Console.WriteLine("printing fabonoccie series");
            if (n == 1)
            {
                Console.Write(" {0}", numb1);
            }
            else if (n == 2)
            {
                Console.Write(" {0} {1}", numb1, numb2);
            }
            else
            {
                Console.Write(" {0} {1}", numb1, numb2);
            }
            for (int i = 3; i <= n; i++)
            {
                sum = numb1 + numb2;
                Console.Write(" {0}", sum);
                numb1 = numb2;
                numb2 = sum;
            }
        }
    }
}
