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
            Console.WriteLine("Hello, World!");
            Console.WriteLine("please choose any one program from below option");
            Console.WriteLine("1.Calculator\n2.FibonoccieSeries\n3.ReverseWord\n4.reverse each words inn same position\n5.reverse number.\n6.palindrom number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Wlcome to basic c# programs");
                    Calculator cal = new Calculator();
                    Console.WriteLine("please enter 1st number");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please enter 2nd number");
                    int y = Convert.ToInt32(Console.ReadLine());
                    cal.AddTwoNumber(x, y);
                    cal.Substraction(x, y);
                    cal.Multiplication(x, y);
                    break;

                case 2:
                    Console.WriteLine("please enter how many series you want to generate");
                    int n = Convert.ToInt32(Console.ReadLine());
                    FibonoccieSeries.Generatefibinoccienumb(n);
                    break;
                case 3:
                    Console.WriteLine("please enter words");
                    string Word = Console.ReadLine();
                    Reverse.ReverseWord(Word);
                    break;
                case 4:
                    Console.WriteLine("plese enter a statement");
                    Word = Console.ReadLine();
                    Reverse.ReverseEachWordInSamePosition(Word);
                    break;
                case 5:
                    Console.WriteLine("please enter any number");
                    x = Convert.ToInt32(Console.ReadLine());
                    Reverse.ReverseNumber(x);
                    break;
                case 6:
                    Console.WriteLine("please enter any number");
                    x = Convert.ToInt32(Console.ReadLine());
                    Reverse.Palindrome(x);
                    break;
                default:
                    Console.WriteLine("please choose existing program");
                    break;
            }
            Console.ReadLine();
        }
    }
}
