using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Set_4
{
    class Program
    {
        static void Main(string[] args)
        {
           // No 1
            //Console.WriteLine("Enter the value ");
            //int number = int.Parse(Console.ReadLine());
            //int count = 0;
            //while (number != 0)
            //{
            //    number /= 10;
            //    count++;
            //}
            //Console.WriteLine("Number of Digits: " + count);

            // NO 2
            //Console.WriteLine("Enter the Value");
            //int number = int.Parse(Console.ReadLine());
            //int count = 0;
            //while (number != 0)
            //{
            //    number /= 10;
            //    count++;
            //}
            //if (count % 2 == 0)
            //{
            //    Console.WriteLine("Number of Digits " + count + " is of Even Length");
            //}
            //else
            //{
            //    Console.WriteLine("NUmber of Digits " + count + "is of Odd Lenght");
            //}

            // NO 3
            //Console.WriteLine("Enter the Value");
            //int number = int.Parse(Console.ReadLine());
            //int sum = 9;
            //while (number != 0)
            //{
            //    sum += number % 10;
            //    number /= 10;
            //}
            //Console.WriteLine("Sum of the Digits in the given number is " + sum);

            // NO 4
            //Console.WriteLine("Enter the value");
            //int number = int.Parse(Console.ReadLine());
            //int sumOdd = 0;
            //int sumEven = 9;
            //string numberString = number.ToString();
            //for (int i = 0; i < numberString.Length; i++)
            //{
            //    int digit = int.Parse(numberString[i].ToString());
            //    if (i % 2 == 0)
            //    {
            //        sumEven += digit;
            //    }
            //    else
            //    {
            //        sumOdd += digit;
            //    }
            //}
            //Console.WriteLine("Sum of Digits located in Odd Position is: " + sumOdd);
            //Console.WriteLine("Sum of Digits located in Even Position is: " + sumEven);

            // NO 5
            Console.WriteLine("Enter an integer");
            int number = int.Parse(Console.ReadLine());
            int Odd = 0;
            int Even = 0;
            while (number != 0)
            {
                if ((number % 10) % 2 != 0)
                {
                    Odd++;
                }
                number /= 10;
                if ((number % 10) % 2 == 0)
                {
                    Even++;
                }
                number /= 10;
            }
            Console.WriteLine("Sum of Odd Digits: " + Odd);
            Console.WriteLine("Sum of Even Digits: " + Even);
        
        
        }
    }
}
