using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Set_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // NO 1
            //Console.WriteLine("Enter the Number 1");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Number 2");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Addition Of " + num1 + " and " + num2 + " is " + (num1 + num2));
            //Console.WriteLine("Differnce of " + num1 + " and " + num2 + " is " + Math.Abs(num1 - num2));
            //Console.WriteLine("Product of " + num1 + " and " + num2 + " is " + (num1 * num2));

            // NO 2
            //Console.WriteLine("Enter the Number 1");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Number 2");
            //int num2 = int.Parse(Console.ReadLine());
            //double result = Math.Pow(num1, num2);
            //Console.WriteLine("Value of " + num1 + " raised to power of " + num2 + " is " + result);

            // NO 3
    //        Console.WriteLine("Enter the Length");
    //        int length = int.Parse(Console.ReadLine());
    //        Console.WriteLine("Enter the Width");
    //        int width = int.Parse(Console.ReadLine());
    //        Console.WriteLine("Enter the Height");
    //        int height = int.Parse(Console.ReadLine());
    //        double volume = length * width * height;
    //        Console.WriteLine("The Volume of the Rectangular Water Tank is : " + volume);

            // No 4
            //Console.WriteLine("Enter the Radius");
            //int radius = int.Parse(Console.ReadLine());
            //double Perimeter = 2 * Math.PI * radius;
            //Console.WriteLine("THe Perimeter of the given circle is" + Perimeter);

            // NO 5
            Console.WriteLine("Enter the Numberator");
            int Numerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Denominator");
            int Denominator = int.Parse(Console.ReadLine());
            int Quotient = Numerator / Denominator;
            int Remainder = Numerator % Denominator;
            Console.WriteLine("The Quotient is" + Quotient);
            Console.WriteLine("The Remainder is" + Remainder);

        }
    }


}
