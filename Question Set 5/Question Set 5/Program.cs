﻿using System;
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
            //Console.WriteLine("Enter an Positive Integer");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("The number of prime numbers less than or equal to " + number + " is: " + CountPrimeNumber(number));

            // NO6
            //Console.WriteLine("Enter an Positive Integer");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("The Sum of the first " + number + " Prime Number is: " + SumPrimeNumber(number));

            // NO 7
            //Console.WriteLine("Enter an Positive Integer");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sum of all prime number less than " + number + " is: " + SumPrime(number));

            // NO 8
            //Console.WriteLine("Enter an Positive integer M");
            //int m = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter an Positive integer N");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Prime numbers between " + m + " and " + n + " is: ");
            //printPrime(m, n);

            // NO 9
            //Console.WriteLine("Enter an Positive Integer");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Prime Factors of " + number + " are: ");
            //printPrimeFactor(number);

            // NO 10
            //Console.WriteLine("Enter an Positive integer M");
            //int m = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter an Positive integer N");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Number of prime numbers betweem " + m + " and " + n + " is: " + CountPrimes(m, n));
            // NO 11
            //Console.WriteLine("Enter an Positive Integer M");
            //int m = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter an Positive integer N");
            //int n = int.Parse(Console.ReadLine());
            //PrintPrime(m, n);

            // NO 12
            //Console.WriteLine("Enter an Positive Integer");
            //int number = int.Parse(Console.ReadLine());
            //int nextPrime = FindNextPrime(number);
            //if (nextPrime == -1)
            //{
            //    Console.WriteLine("There is no next prime number");
            //}
            //else
            //{
            //    Console.WriteLine("The next prime number is: " + nextPrime);
            //}
            // NO 13
            //Console.WriteLine("Enter an Positive Integer");
            //int number = int.Parse(Console.ReadLine());
            //int previousPrime = GetPreviousPrime(number);
            //if (previousPrime == -1)
            //{
            //    Console.WriteLine("There is no next prime numbers");
            //}
            //else
            //{
            //    Console.WriteLine("The previous prime number is: " + previousPrime);
            //}
            // NO 14
            //Console.WriteLine("Enter a Number");
            //int num = int.Parse(Console.ReadLine());
            //int Primenum = FindPrimeNumber(num);
            //if (Primenum == -1)
            //{
            //    Console.WriteLine("There is no prime number");
            //}
            //else
            //{
            //    Console.WriteLine("The nearest prime number is: " + Primenum);
            //}
            // NO 15
            Console.WriteLine("Enter an number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K: ");
            int k = int.Parse(Console.ReadLine());
            int primeNum = FindKPrime(num, k);
            if (primeNum == -1)
            {
                Console.WriteLine("There is no prime number");
            }
            else
            {
                Console.WriteLine("The Kth Prime number is " + primeNum);
            }


        }
        // No 2 and NO 3 and NO 4 and NO 5
        //public static bool IsPrime(int number)
        //{
        //    for (int i = 2; i * i <= number; i++)
        //    {
        //        if (number % i == 0)
        //            return false;
        //    }
        //    return true;
        //}
        //// NO 3
        //public static void printPrimeNumber(int number)
        //{
        //    for (int i = 2; i <= number; i++)
        //    {
        //        if (IsPrime(i))
        //        {
        //            Console.WriteLine(i + " ");
        //        }
        //    }
        //}
        //// NO 4
        //public static void FirstPrimeNumber(int number)
        //{
        //    int count = 0;
        //    int numPrime = 2;
        //    while (count < number)
        //    {
        //        if (IsPrime(numPrime))
        //        {
        //            Console.WriteLine(numPrime + "");
        //            count++;
        //        }
        //        numPrime++;
        //    }
        //}
        //// NO 5
        //public static int CountPrimeNumber(int number)
        //{
        //    int count = 0;
        //    for (int i = 2; i <= number; i++)
        //    {
        //        if (IsPrime(i))
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
        //// NO 6
        //public static int SumPrimeNumber(int number)
        //{
        //    int sum = 0;
        //    int count = 0;
        //    int i = 2;
        //    while (count < number)
        //    {
        //        if (IsPrime(i))
        //        {
        //            sum += i;
        //            count++;
        //        }
        //        i++;
        //    }
        //    return sum;
        //}
        //// NO 7
        //public static int SumPrime(int number)
        //{
        //    int sum = 0;
        //    for (int i = 2; i <= number; i++)
        //    {
        //        if (IsPrime(i))
        //        {
        //            sum += i;
        //        }
        //    }
        //    return sum;
        //}
        //public static void printPrime(int m, int n)
        //{
        //    for (int i = m; i <= n; i++)
        //    {
        //        if (IsPrime(i))
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}
        //// NO 9
        //public static void printPrimeFactor(int number)
        //{
        //    int divisor = 2;
        //    while (divisor <= number)
        //    {
        //        if (number % divisor == 0)
        //        {
        //            Console.WriteLine(divisor);
        //            number = number / divisor;
        //        }
        //        else
        //        {
        //            divisor++;
        //        }
        //    }
        //}
        //// NO 10
        //public static int CountPrimes(int m, int n)
        //{
        //    int count = 0;
        //    for (int i = m; i <= n; i++)
        //    {
        //        if (PrimeIs(i))
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
        //public static bool PrimeIs(int n)
        //{
        //    if (n <= 1) return false;
        //    if (n == 2) return true;
        //    if (n % 2 == 0) return false;
        //    for (int i = 3; i * i <= n; i += 2)
        //    {
        //        if (n % i == 0) return false;
        //    }
        //    return true;
        //}
        //public static void PrintPrime(int m, int n)
        //{
        //    for (int i = m; i <= n; i++)
        //    {
        //        if (PrimeIs(i))
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}
        // NO 12
        //public static int FindNextPrime(int number)
        //{
        //    if (number <= 1) return 2;
        //    for (int i = number + 1; ; i++)
        //    {
        //        if (PrimeIs(i))
        //        {
        //            return i;
        //        }
        //    }
        //}
        //public static int GetPreviousPrime(int number)
        //{
        //    if (number <= 2) return -1;
        //    for (int i = number - 1; ; i--)
        //    {
        //        if (PrimeIs(i))
        //        {
        //            return i;
        //        }
        //    }
        //}

        // NO 14
        public static int FindPrimeNumber(int num)
        {
            bool isprime = NearPrime(num);
            for (int i = num; i > 1; i--)
            {
                isprime = NearPrime(i);
                if (isprime)
                {
                    return i;
                }
            }
            return -1;
        }
        public static bool NearPrime(int num)
        {
            if (num <= 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        // NO 15
        public static int FindKPrime(int num, int k)
        {
            int primeCount = 0;
            int primeNum = -1;
            for (int i = num; i > 1; i--)
            {
                if (NearPrime(i))
                {
                    primeCount++;
                }
                if (primeCount == k)
                {
                    primeNum = i;
                    break;
                }
            }
            return primeNum;
        }
    }
}
