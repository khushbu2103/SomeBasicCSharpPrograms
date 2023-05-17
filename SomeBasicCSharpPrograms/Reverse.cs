using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeBasicCSharpPrograms
{
    internal class Reverse
    {
        public static string ReverseWord(string Word)
        {
            String reverse = "";
            foreach (char latter in Word)
            {
                reverse = latter + reverse;
            }
            //Console.Write(reverse);
            return reverse;
        }

        public static void ReverseEachWordInSamePosition(string statement)
        {
            String reverse = "";
            char[] delimeters = { ' ', ',', ':' };
            string[] Words = statement.Split(delimeters);
            foreach (string Word in Words)
            {
                string r = ReverseWord(Word);
                reverse = reverse + r + " ";
            }
            Console.Write(reverse);
        }

        public static int ReverseNumber(int Number)
        {
            int Reminder = 0;
            int reverse = 0;

            while (Number != 0)
            {
                Reminder = Number % 10;
                reverse = (reverse * 10) + Reminder;
                Number = Number / 10;
            }
            return reverse;
        }

        public static void Palindrome(int Number)
        {
            int output = ReverseNumber(Number);
            if (Number == output)
            {
                Console.WriteLine("{0} is palindrome:", Number);
            }
            else
            {
                Console.WriteLine("{0} is not polindrome", Number);
            }
        }
       
    }
}
