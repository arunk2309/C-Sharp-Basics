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
            //Console.WriteLine("Enter the Numberator");
            //int Numerator = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Denominator");
            //int Denominator = int.Parse(Console.ReadLine());
            //int Quotient = Numerator / Denominator;
            //int Remainder = Numerator % Denominator;
            //Console.WriteLine("The Quotient is" + Quotient);
            //Console.WriteLine("The Remainder is" + Remainder);

            // NO 6
            //Console.WriteLine("Enter the Number");
            //int number = int.Parse(Console.ReadLine());
            //double Square = Math.Pow(number, 2);
            //Console.WriteLine("The Square of a given number is " + Square);

            // N0 7
            //Console.WriteLine("Enter the Number");
            //int number = int.Parse(Console.ReadLine());
            //double SquareRoot = Math.Sqrt(number);
            //Console.WriteLine("The Square Root of a given number " + SquareRoot);

            // NO 8
            //Console.WriteLine("Enter the Base of Traingle");
            //double Base = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Height of the Triangle");
            //double height = double.Parse(Console.ReadLine());
            //double Area = 0.5 * Base * height;
            //Console.WriteLine("The Area of the Triangle is" + Area);

            // No 9
            //Console.WriteLine("Enter the Distance in Kilometer");
            //double KM = double.Parse(Console.ReadLine());
            //double Miles = KM * 0.621371;
            //Console.WriteLine("The Distance in Miles is" + Miles);

            // NO 10
            //Console.WriteLine("Enter the Temperature in Celsius");
            //double Celsius = double.Parse(Console.ReadLine());
            //double Fareheit = (Celsius * 9) / 5 + 32;
            //Console.WriteLine("The Tenoerature in Fareheit is" + Fareheit);

            // NO 11
            //Console.WriteLine("Enter the Value of A");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Value of B");
            //int b = int.Parse(Console.ReadLine());
            //int temp = a;
            //a = b;
            //b = temp;
            //Console.WriteLine("After Swapping");
            //Console.WriteLine("A" + a);
            //Console.WriteLine("B" + b);

            // NO 12
            //int a = 20;
            //int b = 50;
            //Console.WriteLine("Before Swapping");
            //Console.WriteLine(" A " + a);
            //Console.WriteLine(" B " + b);
            //a = a + b;
            //b = a - b;
            //a = a - b;
            //Console.WriteLine("After swapping");
            //Console.WriteLine(" A " + a);
            //Console.WriteLine(" B " + b);

            // NO 13
            //int a = 20;
            //int b = 50;
            //Console.WriteLine("Before Swapping");
            //Console.WriteLine(" A " + a);
            //Console.WriteLine(" B " + b);
            //if (a > b)
            //{
            //    int temp = a;
            //    a = b;
            //    a = temp;
            //}
            //else
            //{
            //    int temp = b;
            //    b = a;
            //    a = temp;
            //}
            //Console.WriteLine("After Swapping");
            //Console.WriteLine(" A " + a);
            //Console.WriteLine(" B " + b);
            
            // NO 14
            //Random random = new Random();
            //int number = random.Next(1, 100);
            //Console.WriteLine(" Generated Number " + number);
            

            // NO 15
            Console.WriteLine(" Enter the Length in Feet :");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the Width in Feet ");
            int width = int.Parse(Console.ReadLine());
            int areainacres = Calculateareainacres(length, width);
            Console.WriteLine(" The Area of the Field is: " + areainacres);
          

        }

        // NO 15
        public static int Calculateareainacres(int length, int widht)
        {
            int squarefeettoacres = 43568;
            long areatosquarefeet = (long)length * widht;
            int areainacres = (int)areatosquarefeet / squarefeettoacres;
            return areainacres;
        }
    }


}
