using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Set_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // NO 1
            //Console.WriteLine("Enter the Number");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i < number; i++)
            //{
            //    Console.WriteLine(i);
            //}
            // NO 2
            //Console.WriteLine("Enter the Value M");
            //int M = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Value N");
            //int N = int.Parse(Console.ReadLine());
            //if (M >= N)
            //{
            //    Console.WriteLine("invalid input M is always less than N");
            //}
            //else
            //{
            //    for (int i = M; i <= N; i++)
            //    {
            //        Console.WriteLine("The number between M Upto N is");
            //        Console.WriteLine(i);
            //    }
            //}
            // NO 3
            //Console.WriteLine("Enter an Integer");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write("The Even number for 1 upto N: ");
            //        Console.WriteLine(i);
            //    }
            //}
            // NO 4
            //Console.WriteLine("Enter an Value");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine("The Odd number from 1 Upto N is: ");
            //        Console.WriteLine(i);
            //    }
            //}
            // NO 5
            //Console.WriteLine("Enter the Value of M");
            //int M = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Value of N");
            //int N = int.Parse(Console.ReadLine());
            //if (M < N)
            //{
            //    for (int i = M; i <= N; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            // NO 6
            //Console.WriteLine("Enter the Value of M");
            //int M = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Value of N");
            //int N = int.Parse(Console.ReadLine());
            //for (int i = M; i <= N; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            // NO 7
            //Console.WriteLine("Enter the Value of N");
            //int N = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % N == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            // NO 8
            //Console.WriteLine("Enter the Value of N");
            //int N = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(N + " X " + i + " = " + (N * i));
            //}
            // NO 9
            //Console.WriteLine("Multiplication Tables");
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("Table for " + i);
            //        for (int j = 1; j <= 20; j++)
            //        {
            //            int result = i * j;
            //            Console.WriteLine(+i + " X " + j + " = " + result);
            //        }
            //}
            // NO 10
            Console.WriteLine("Enter the Value of N");
            int n = int.Parse(Console.ReadLine());
            int sum = CalculateSum(n);
            Console.WriteLine("The sum of all number between 1 and " + n + " is " + sum);
    }
        // No 10
        public static int CalculateSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
