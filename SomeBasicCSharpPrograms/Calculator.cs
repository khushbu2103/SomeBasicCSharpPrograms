using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeBasicCSharpPrograms
{
    internal class Calculator
    {
        public void AddTwoNumber(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine($"sum: {sum}");
        }
        public void Substraction(int x, int y)
        {
            int diff = Math.Abs(x - y);
            Console.WriteLine("Difference: {0}", diff);
        }
        public void Multiplication(int x, int y)
        {
            int multiplication = x * y;
            Console.WriteLine("multiplication: {0}", multiplication);
        }
    }
}
