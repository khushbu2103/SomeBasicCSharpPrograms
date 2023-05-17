using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeBasicCSharpPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic c# programs");
            Console.WriteLine("Wlcome to basic c# programs");
            Calculator cal = new Calculator();
            Console.WriteLine("please enter 1st number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter 2nd number");
            int y = Convert.ToInt32(Console.ReadLine());
            cal.AddTwoNumber(x, y);
            cal.Substraction(x, y);
            cal.Multiplication(x, y);
            Console.ReadLine();
        }
    }
}
