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
        private static void Targil4()
        {
            Console.WriteLine("enter 1 number");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int B = int.Parse(Console.ReadLine());
            int num = A * B;
            if (A > B)
                Console.WriteLine("A is bigger than B ");
            else
            {
                num = B - A;
                Console.WriteLine("A is smaller then B");
            }
            Console.WriteLine(num);
        }
        static void targil5()
        {
            Console.WriteLine("enter 3 didgets number");
            int num = int.Parse(Console.ReadLine());

            int meot = num / 100;
            int units = num % 10;
            int mid = num / 10 % 10;
            int caful = meot * units;
            int midl = mid * mid;
            if (caful == midl)
            {
                Console.WriteLine(num);
            }
            else Console.WriteLine(mid);

        }
        static void targil6()
        {
            Console.WriteLine("Enter the day in December:");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the year:");
            int year = int.Parse(Console.ReadLine());

            int month = 12;
            int days = day + 20;
            if (days > 30)
            {
                int months = month - 11;
                int newyeardate = (year + 1);
                int dayss = days % 30;
                Console.WriteLine("{0}/{1}/{2}", dayss, months, newyeardate);
            }
            else
            {
                int newdaydate = day + 20;
                Console.WriteLine("{0}/{1}/{2}", newdaydate, month, year);
            }
        }
        static void Main(string[] args)
        {
            Console.ReadLine();
            
        }
    }
}
