using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Home_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Task56();
            Task57();
            Task58();
            Task168();
            Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();

        }
        public static void Task56()
        {
            Console.WriteLine("Input the integer m");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the integer n");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("No solution. n = 0");
            }
            else
            {
                if (m % n == 0)
                {
                    Console.WriteLine("m/n = " + m / n);
                }
                else
                {
                    Console.WriteLine("m is not completely divided by n");
                }
            }
        }

        public static void Task57()
        {
            Console.WriteLine("Input integer a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input integer b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((b % a == 0 ? "a is divisor of b" : "a is NOT a divisor of b"));
        }

        public static void Task58()
        {
            Console.WriteLine("Input a number");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m + " is " + (m % 2 == 0 ? "Chet" : "NeChet"));
        }

        public static void Task168()
        {
            double a = 1, b = 2, c = 3, d = 4, e = 5, f = 6, x, y;
            Console.WriteLine("Input a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input c");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input d");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input e");
            e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input f");
            f = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    x = (b > c ? b : c);
                }
                else
                {
                    x = a;
                }
            }
            else
            {
                if (a < c)
                {
                    x = (b < c ? b : c);
                }
                else
                {
                    x = a;
                }
            }


            if (d > e)
            {
                if (d > f)
                {
                    y = (e > c ? e : f);
                }
                else
                {
                    y = d;
                }
            }
            else
            {
                if (d < f)
                {
                    y = (e < f ? e : f);
                }
                else
                {
                    y = d;
                }
            }
            Console.WriteLine($"middle of a,b,c is {x}, middle of d,e,f is {y}, (a+b)/2 = {Convert.ToString((y + x) / 2)}");
            Console.WriteLine(Convert.ToString((y+x)/2));
            Console.ReadLine();
        }

        public static void Task1()
        {
            //int a = 1, b = 2, c = 3;
            double a = 1, b = 2, c = 3, x;
            Console.WriteLine("Input a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input c");
            c = Convert.ToDouble(Console.ReadLine());

            if (a != 0 & (b * b + 4 * a * c) >= 0)
            {
                x = (b + Math.Pow((b * b + 4 * a * c), 0.5)) / 2 / a - Math.Pow(a, 3) * c + Math.Pow(b, (-2));
                Console.WriteLine("Task1 = " + x);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No solution");
                Console.ReadLine();
            }
        }

        public static void Task2()
        {
            double a = 1, b = 2, c = 3, d = 4;
            double x;
            x = a * b / (c * d) - (a * b - c) / (c * d);
            Console.WriteLine("Task2 = " + x);
            Console.ReadLine();
        }

        public static void Task3()
        {
            double x = 2, y = 3, z;
            Console.WriteLine("x = " + x + ", y = " + y);
            z = (Math.Sin(x) + Math.Cos(y)) / (Math.Cos(x) - Math.Sin(y)) * Math.Tan(x * y);
            Console.WriteLine("Task3 = " + z);
            Console.ReadLine();
        }

        public static void Task4()
        {
            double x = 5, y = 6, z;
            Console.WriteLine("x = " + x + ", y = " + y);
            z = (x + y) / (y + 1) - (x * y - 12) / (34 + x);
            Console.WriteLine("Task4 = " + z);
            Console.ReadLine();
        }

        public static void Task5()
        {
            double x, y, z;
            Console.WriteLine("Input x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input y:");
            y = Convert.ToDouble(Console.ReadLine());
            z = (3 + Math.Pow(Math.E, y - 1)) / (1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(x)));
            Console.WriteLine("Task5 = " + z);
            Console.ReadLine();
        }

        public static void Task6()
        {
            double x, z;
            Console.WriteLine("Input x:");
            x = Convert.ToDouble(Console.ReadLine());
            z = x - Math.Pow(x, 3) / 3 + Math.Pow(x, 5) / 5;
            Console.WriteLine("Task6 = " + z);
            Console.ReadLine();
        }
    }
}

