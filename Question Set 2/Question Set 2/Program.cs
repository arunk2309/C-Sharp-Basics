using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Set_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // NO 1
            //Console.WriteLine("Enter the Number:");
            //int number = int.Parse(Console.ReadLine());
            //if (number > 0)
            //{
            //    Console.WriteLine(" Number is Positive: ");
            //}
            //else if (number < 0)
            //{
            //    Console.WriteLine(" NUmber is Negative :");
            //}
            // NO 2
            //Console.WriteLine("Enter the Number 1:");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Number 2:");
            //int number2 = int.Parse(Console.ReadLine());
            //if (number1 == number2)
            //{
            //    Console.WriteLine("Number is Equal");
            //}
            //else
            //{
            //    Console.WriteLine("Number is Not Equal");
            //}
            // NO 3
            //Console.WriteLine("Enter the first Floating Point Number");
            //float fp1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second Floating Point Number");
            //float fp2 = float.Parse(Console.ReadLine());
            //if (fp1 == fp2)
            //{
            //    Console.WriteLine("Two Floating Point Numbers are Equal");
            //}
            //else
            //{
            //    Console.WriteLine("Two Floating Point Number are Not Equal");
            //}
            // NO 4
            //Console.WriteLine("Enter a Number");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Entered Number is Even Number");
            //}
            //else
            //{
            //    Console.WriteLine("Entered Number is Odd Number");
            //}
            // NO 5
            //Console.WriteLine("Enter the Year");
            //int year = int.Parse(Console.ReadLine());
            //if (((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)))
            //{
            //    Console.WriteLine("Is a Leap Year", year);
            //}
            //else
            //{
            //    Console.WriteLine("Is not a Leap year", year);
            //}
            // NO 6
            //Console.WriteLine("Enter the Age");
            //int Age = int.Parse(Console.ReadLine());
            //if (Age >= 18)
            //{
            //    Console.WriteLine("HE or She is Eligible to cast her vote");
            //}
            //else
            //{
            //    Console.WriteLine("He or She is not Eligible to cast her vote");
            //}

            //NO 7
            //Console.WriteLine("Enter the Height of the Person");
            //int height = int.Parse(Console.ReadLine());
            //if (height > 220)
            //{
            //    Console.WriteLine("You are Classifed as a Tall");
            //}
            //else if (height < 160)
            //{
            //    Console.WriteLine("You are Classified as a Short");
            //}
            //else
            //{
            //    Console.WriteLine("You are Classified as a Medium");
            //}

            // NO 8
            //Console.WriteLine("Enter the Value for A");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Value of B");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Value of C");
            //int c = int.Parse(Console.ReadLine());
            //int result = LargestNumber(a, b, c);
            //Console.WriteLine("The Largest Among Three Numbers is: " + result);

            // NO 9
            //Console.WriteLine("Enter the Value of A");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the value of B");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Value of C");
            //int c = int.Parse(Console.ReadLine());
            //int result = SmallestNumber(a, b, c);
            //Console.WriteLine("The Smallest amount Three Number is: " + result);

            // NO 10
            Console.WriteLine("Enter the Value of A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Value of B");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Value of C");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Value of D");
            int d = int.Parse(Console.ReadLine());
            int result = LargestFourNumber(a, b, c, d);
            Console.WriteLine("The Largest Among Four Number is: " + result);
        }

        // No 8
        public static int LargestNumber(int a, int b, int c)
        {
            if (a >= b && a >= c)
                return a;
            else if (b >= a && b >= c)
                return b;
            else
                return c;
        }
        // NO 10
        public static int SmallestNumber(int a, int b, int c)
        {
            if (a <= b && a <= c)
                return a;
            else if (b <= a && b <= c)
                return b;
            else
                return c;
        }

        // No 10
        public static int LargestFourNumber(int a, int b, int c, int d)
        {
            if (a >= b && a >= c && a >= d)
                return a;
            else if (b >= a && b >= c && b >= d)
                return b;
            else if (c >= a && c >= b && c >= d)
                return c;
            else
                return d;
        }
    }
}
