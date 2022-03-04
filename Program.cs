using System;

namespace CheckMaximumNumber
{
    class program
    {
        static void Main(string[]args)
        {

            Console.WriteLine("Welcome to the Maximum Problem Using Generics");

            //U-1-for Integer

            int num1 = 33;
            int num2 = 23;
            int num3 = 15;


            //int value = num1.CompareTo(num2);
            //int value1 = num1.CompareTo(num3);
            //int value2 = num2.CompareTo(num3);

            if (num1.CompareTo(num2) >= 0 && (num1.CompareTo(num3)) >= 0) 
            {
                Console.WriteLine("the max is " + num1);
            }

            else if (num2.CompareTo(num3) >= 0 && num2.CompareTo(num1) >= 0)
            {
                Console.WriteLine("the max is " +  num2);
            }
            else
            {
                Console.WriteLine("the max is " + num3);
            }

            //UC-2-for Double

            double num4 = 34.5;
            double num5 = 21.3;
            double num6 = 12.33;

            if (num4.CompareTo(num5) >= 0 && (num4.CompareTo(num6)) >= 0)
            {
                Console.WriteLine("the max is " + num4);
            }

            else if (num5.CompareTo(num4) >= 0 && num5.CompareTo(num6) >= 0)
            {
                Console.WriteLine("the max is " + num5);
            }
            else
            {
                Console.WriteLine("the max is " + num6);
            }

            //UC-3 for string

            string num7 = "hello";
            string num8 = "how";
            string num9 = "you";

            if (num7.CompareTo(num8) >= 0 && (num7.CompareTo(num9)) >= 0)
            {
                Console.WriteLine("the max is " + num7);
            }

            else if (num8.CompareTo(num7) >= 0 && num8.CompareTo(num9) >= 0)
            {
                Console.WriteLine("the max is " + num8);
            }
            else
            {
                Console.WriteLine("the max is " + num9);
            }

        }
    }
}
