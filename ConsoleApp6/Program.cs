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
        static void targil7()
        {
            Console.WriteLine("eneter 3 Letters in the order of the Alpha bet");
            string input = Console.ReadLine();

            if (input.Length != 3)
            {
                Console.WriteLine("there are no 3 letters");
            }

            char char1 = input[0];
            char char2 = input[1];
            char char3 = input[2];
            int chack = (char)(char1 + 1);
            if ((char2 == (char)(char1 + 1)) && (char3 == (char)(char2 + 1)))
            {
                Console.WriteLine("the characters follow the alpha bet");
                Console.WriteLine(char1);
                Console.WriteLine((char)(char1 + 1));
                Console.WriteLine((char)(char2 + 1));
                Console.WriteLine((char)(char3 + 1));
            }
            else
            {
                Console.WriteLine("the characters arent in order of the alpha bet");
            }
        }
        static void targil8()
        {
            Console.WriteLine("enter 3 numbers in 3 diffrent lines");
            int numbers = int.Parse(Console.ReadLine());
            int num3 = numbers % 10;
            int num2 = (numbers / 10) % 10;
            int num1 = numbers / 100;
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1 is the biggest number");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("num2 is the biggest");
            }
            else Console.WriteLine("num3 is the biggest");

        }
        static void targil9()
        {
            Console.WriteLine("enter 3 length of a tringle");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a + b <= c || b + c <= a || c + a <= b)
            {
                Console.WriteLine("cannot create triangle");
            }
            else if (a == b && b == c)
            {
                Console.WriteLine("triangle is an equilateral triangle");
            }
            else if (a == b || b == c || c == a)
            {
                Console.WriteLine("triangle is an isosceles triangle");
            }
            else if (a * a + b * b == c * c || b * b + c * c == a * a || c * c + a * a == b * b)
            {
                Console.WriteLine("its a right triangle");
            }
            else
            {
                Console.WriteLine("this is a triangle");
            }

        }
        static void targil10()
        {
            Console.WriteLine("enter a three-digit number:");
            int number = int.Parse(Console.ReadLine());

            int num1 = number % 10;
            int num2 = number / 10 % 10;
            int num3 = number / 100;

            if (num1 % 2 != 0)
            {
                num1 -= 1;
            }

            if (num2 % 2 != 0)
            {
                num2 -= 1;
            }

            if (num3 % 2 != 0)
            {
                num3 -= 1;
            }

            int encryptedCode = num3 * 100 + num2 * 10 + num1;
            Console.WriteLine("encrypted code: " + encryptedCode);
        }
        static void Main(string[] args)
        {

            Console.ReadLine();           
        }
    }
}
