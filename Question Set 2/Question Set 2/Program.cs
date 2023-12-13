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
            Console.WriteLine("Enter the Year");
            int year = int.Parse(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)))
            {
                Console.WriteLine("Is a Leap Year", year);
            }
            else
            {
                Console.WriteLine("Is not a Leap year", year);
            }
        }
    }
}
