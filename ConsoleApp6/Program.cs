using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Targil1()
        {
            Console.WriteLine("enter speed of the car");
            int speed = int.Parse(Console.ReadLine());
            if (speed <= 54 || speed >= 101)
            {
                Console.WriteLine("speed is not good");
            }
            else
            {
                Console.WriteLine("speed is good");
            }

        }

        static void Targil2()
        {
            Console.WriteLine("eneter a number 0-100");
            int num = int.Parse(Console.ReadLine());
            if (num % 7 == 0 || num.Equals("7"))
            {
                Console.WriteLine("boom");
            }
            else
            {
                Console.WriteLine("number doesnt have any connections to 7");
            }
        }
        static void targil3()
        {
            Console.WriteLine("enter 3 didgets number that also Palindrome");
            int num = int.Parse(Console.ReadLine());
            if (num >= 100 && num < 999)
            {
                int num1 = num / 100;
                int num2 = num % 10;
                if (num1 == num2)
                {
                    Console.WriteLine("number is Palindrome");
                }
                else
                {
                    Console.WriteLine("number is not Palindrome");
                }
            }
            else
            {
                Console.WriteLine("number is not 3 didget");
            }


            Console.ReadLine();
        }
        static void Main(string[] args)
        {


                Console.ReadLine();
        }
    }
}
