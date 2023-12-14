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
            //Console.WriteLine("Enter an integer");
            //int number = int.Parse(Console.ReadLine());
            //int Odd = 0;
            //int Even = 0;
            //while (number != 0)
            //{
            //    if ((number % 10) % 2 != 0)
            //    {
            //        Odd++;
            //    }
            //    number /= 10;
            //    if ((number % 10) % 2 == 0)
            //    {
            //        Even++;
            //    }
            //    number /= 10;
            //}
            //Console.WriteLine("Count of Odd Digits: " + Odd);
            //Console.WriteLine("Count of Even Digits: " + Even);

            // NO 6
            //Console.WriteLine("Enter an Integer");
            //int number = int.Parse(Console.ReadLine());
            //int sumOdd = 0;
            //int sumEven = 0;
            //while (number != 0)
            //{
            //    if ((number % 10) % 2 != 0)
            //    {
            //        sumOdd += number % 10;
            //    }
            //    number /= 10;
            //    if ((number % 10) % 2 == 0)
            //    {
            //        sumEven += number % 10;
            //    }
            //    number /= 10;
            //}
            //Console.WriteLine("Sum of Odd Digits:" + sumOdd);
            //Console.WriteLine("Sum of Even Digits:" + sumEven);
            // NO 7
            //Console.WriteLine("Enter an Integer");
            //int number = int.Parse(Console.ReadLine());
            //int lastdigit = number % 10;
            //Console.WriteLine("The Last Digit of the given integer is: " + lastdigit);

            // NO 8
            //Console.WriteLine("Enter an Integer");
            //int number = int.Parse(Console.ReadLine());
            //int firstdigit = number;
            //while (firstdigit >= 10)
            //{
            //    firstdigit /= 10;
            //}
            //Console.WriteLine("First Digit of the given integer is:" + firstdigit);

            // NO 9
            //Console.WriteLine("Enter an Integer");
            //int number = int.Parse(Console.ReadLine());
            //int maxDigit = getMaxDigit(number);
            //Console.WriteLine("Maximum Digit of the given integer is:" + maxDigit);

            // NO 10
            //Console.WriteLine("Enter an Integer");
            //int number = int.Parse(Console.ReadLine());
            //int maxDigit = int.MinValue;
            //int maxDigitPostion = 0;
            //int postion = 1;
            //while (number > 0)
            //{
            //    int digit = number % 10;
            //    if (digit > maxDigit)
            //    {
            //        maxDigit = digit;
            //        maxDigitPostion = postion;
            //    }
            //    number /= 10;
            //    postion *= 10;
            //}
            //Console.WriteLine("Maximum Digit is " + maxDigit);
            //Console.WriteLine("Maximum Digit Location is " + maxDigitPostion);

            // NO 11
            //Console.WriteLine("Enter an Integer");
            //int number = int.Parse(Console.ReadLine());
            //int minDigit = getMinDigit(number);
            //Console.WriteLine("Minimum Digit of the given integer is: " + minDigit);

            // NO 12
            //Console.WriteLine("Enter an Integer");
            //int number = int.Parse(Console.ReadLine());
            //string numStr = Math.Abs(number).ToString();
            //int minDigit = numStr[0] - '0';
            //int minDigitLocation = 1;
            //for (int i = 1; i < numStr.Length; i++)
            //{
            //    int currenDigit = numStr[i] - '0';
            //    if (currenDigit < minDigit)
            //    {
            //        minDigit = currenDigit;
            //        minDigitLocation = (int)Math.Pow(10, i);
            //    }
            //}
            //Console.WriteLine("Minimum Digit is: " + minDigit);
            //Console.WriteLine("Minimum Digit Location is: " + minDigitLocation);
            // No 12
            //Console.WriteLine("Enter an Integer");
            //int number = int.Parse(Console.ReadLine());
            //int minDigit = int.MaxValue;
            //int minDigitPostion = 0;
            //int postion = 1;
            //while (number > 0)
            //{
            //    int digit = number % 10;
            //    if (digit < minDigit)
            //    {
            //        minDigit = digit;
            //        minDigitPostion = postion;
            //    }
            //    number /= 10;
            //    postion *= 10;
            //}
            //Console.WriteLine("Minimum Digit is " + minDigit);
            //Console.WriteLine("Minimum Digit Location is " + minDigitPostion);

            // NO 13
            //Console.WriteLine("Enter an Integer");
            //int number = int.Parse(Console.ReadLine());
            //int reversedNumber = reverseNumber(number);
            //Console.WriteLine("The Reverse number of the given " + number + " is: " + reversedNumber);
            
            // NO 14
            //Console.WriteLine("Enter an Integer");
            //int number = int.Parse(Console.ReadLine());
            //int digitalroot = DigitalRoot(number);
            //Console.WriteLine("The Digital Root of the given " + number + " is: " + digitalroot);

            // NO 15
            Console.WriteLine("Enter an Integer");
            int number = int.Parse(Console.ReadLine());
            bool result = CheckAllDivide(number);
            Console.WriteLine("All Digits of given " + number + " divide by " + number + " is: " + result);

        }

        // NO 9
        public static int getMaxDigit(int number)
        {
            int maxDigit = -1;
            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;
                if (digit > maxDigit)
                {
                    maxDigit = digit;
                }
            }
            return maxDigit;

        }

        // NO 11
        public static int getMinDigit(int number)
        {
            int minDigit = int.MaxValue;
            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;
                if (digit < minDigit)
                {
                    minDigit = digit;
                }
            }
            return minDigit;
        }
        // NO 12
        //public static int getMinDigitLocation(int number)
        //{
        //    int minDigit = int.MaxValue;
        //    int minDigitLocation = 0;
        //    while (number != 0)
        //    {
        //        int digit = number % 10;
        //        number /= 10;
        //        if (digit < minDigit)
        //        {
        //            minDigit = digit;
        //            minDigitLocation = 1;
        //        }
        //        else if (digit == minDigit)
        //        {
        //            minDigitLocation++;
        //        }
        //    }
        //    return minDigitLocation;
        //}
        // NO 13
        public static int reverseNumber(int number)
        {
            int reversedNumber = 0;
            while (number != 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number /= 10;
            }
            return reversedNumber;
        }
        // no 15
        public static int DigitalRoot(int number)
        {
            int digitalroot = 0;
            while (number != 0)
            {
                int digit = number % 10;
                digitalroot += digit;
                number /= 10;
            }
            return (digitalroot > 9) ? DigitalRoot(digitalroot) : digitalroot;
        }
        // NO 15
        public static bool CheckAllDivide(int number)
        {
            int originalnumber = number;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit == 0 || originalnumber != 0)
                {
                    return false;
                }
                number /= 10;
            }
            return true;
        }
    }
}
