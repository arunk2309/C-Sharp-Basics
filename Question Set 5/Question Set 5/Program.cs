using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Set_5
{
    class Program
    {
        static void Main(string[] args)
        {

            // NO 1
            //Console.WriteLine("Enter a Positive Integer");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("The Factors of " + number + " are: ");
            //for (int i = 1; i <= number; i++)
            //{
            //    if (number % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            // NO 2
            //Console.WriteLine("Enter a Positive Integer");
            //int number = int.Parse(Console.ReadLine());
            //if (IsPrime(number))
            //{
            //    Console.WriteLine(number + " Is a Prime Number: ");
            //}
            //else
            //{
            //    Console.WriteLine(number + " Is not a prime Number; ");
            //}
            // NO 3
            //Console.WriteLine("Enter an Positive Integer");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Prime Number from 1 to " + number + " are: ");
            //printPrimeNumber(number);

            // NO 4
            //Console.WriteLine("Enter an Positive Integer");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("The First " + number + " Prime numbers are: ");
            //FirstPrimeNumber(number);

            // NO 5
            Console.WriteLine("Enter an Positive Integer");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The number of prime numbers less than or equal to " + number + " is: " + CountPrimeNumber(number));
        }
        // No 2 and NO 3 and NO 4 and NO 5
        public static bool IsPrime(int number)
        {
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        // NO 3
        public static void printPrimeNumber(int number)
        {
            for (int i = 2; i <= number; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
        // NO 4
        public static void FirstPrimeNumber(int number)
        {
            int count = 0;
            int numPrime = 2;
            while (count < number)
            {
                if (IsPrime(numPrime))
                {
                    Console.WriteLine(numPrime + "");
                    count++;
                }
                numPrime++;
            }
        }
        // NO 5
        public static int CountPrimeNumber(int number)
        {
            int count = 0;
            for (int i = 2; i <= number; i++)
            {
                if (IsPrime(i))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
