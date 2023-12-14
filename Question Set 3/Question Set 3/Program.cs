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
            //Console.WriteLine("Enter the Value of N");
            //int n = int.Parse(Console.ReadLine());
            //int sum = CalculateSum(n);
            //Console.WriteLine("The sum of all number between 1 and " + n + " is " + sum);

            // NO 11
            //Console.WriteLine("Enter the Value of N");
            //int N = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= N; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine("The Sum of all Even Number between 1 and " + N + " is " + sum);
            // NO 12
            //Console.WriteLine("Enter the Value of N");
            //int N = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= N; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine("The sum of all Odd Number between 1 and " + N + " is " + sum);
            // NO 13
            //Console.WriteLine("Enter the Value of K");
            //int K = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Value of N");
            //int N = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= N; i++)
            //{
            //    if (i % K == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine("The sum of all Multiplies " + K + " between 1 and " + N + " is " + sum);
            // NO 14
            //Console.WriteLine("Enter the Value of N");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine("FIzzBuzz");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            // NO 15
            //Console.WriteLine("Enter the Value of N");
            //int n = int.Parse(Console.ReadLine());
            //long factorial = CalculateFactorial(n);
            //Console.WriteLine("The Factorial of a Given " + n + " is " + factorial);
            // NO 16
            //Console.WriteLine("Enter the number of subjects:");
            //int numberofsubjects = int.Parse(Console.ReadLine());
            //int totalMarks = 0;
            //for (int i = 1; i <= numberofsubjects; i++)
            //{
            //    Console.WriteLine("Enter the Mark of the Subject " + i + " : ");
            //    int subjectMarks;
            //    while (!int.TryParse(Console.ReadLine(), out subjectMarks) || subjectMarks < 0 || subjectMarks > 100)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid mark between 0 and 100.");
            //    }
            //    totalMarks += subjectMarks;
            //}
            //double averageMarks = (double)totalMarks / numberofsubjects;
            //Console.WriteLine("Total Mark is: " + totalMarks);
            //Console.WriteLine("Average Mark is: " + averageMarks);

            // NO 17
            //Console.WriteLine("Enter the Value of N ");
            //int n = int.Parse(Console.ReadLine());
            //if (n > 0)
            //{
            //    int[] score = new int[n];
            //    int total = 0;
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.WriteLine("Enter the Score for the round " + i);
            //        score[i] = int.Parse(Console.ReadLine());
            //        total+=score[i];
            //        Console.WriteLine("Running Total is: " + total);
            //    }
            //    Console.WriteLine("Final Total is: " + total);
            //}

            // NO 18
            //Console.WriteLine("Welcome to Calculator: Please 'quit' at any time to exit the program");
            //while (true)
            //{
            //    Console.WriteLine("Enter the two number for an operation (Add, Sub, Mul, Div):");
            //    string[] inputs = Console.ReadLine().Split();
            //    if (inputs[0] == "quit")
            //    {
            //        break;
            //    }
            //    double num1 = double.Parse(inputs[0]);
            //    double num2 = double.Parse(inputs[1]);
            //    Console.WriteLine("Please enter the operation would you like to perform (Add, Sub, Mul, Div):");
            //    string operation = Console.ReadLine();
            //    if (operation == "quit")
            //    {
            //        break;
            //    }
            //    double result = 0;
            //    switch (operation)
            //    {
            //        case "Add":
            //            result = num1 + num2;
            //            break;
            //        case "Sub":
            //            result = num1 - num2;
            //            break;
            //        case "Mul":
            //            result = num1 * num2;
            //            break;
            //        case "Div":
            //            if (num2 == 0)
            //            {
            //                Console.WriteLine("Error:Divisible by Zero is not allowed");
            //                continue;
            //            }
            //            result = num1 / num2;
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Opertion");
            //            continue;
            //    }
            //    Console.WriteLine("The result of the Operation is:" + result);
            //    Console.WriteLine("Would you like to continue type 'Yes' to continue or press 'quit' to exit");
            //    string continuePrompt = Console.ReadLine();
            //    if (continuePrompt == "quit")
            //    {
            //        break;
            //    }
            //}
            // NO 19
            //Console.WriteLine("Welcome to Rock, Paper, Scissor Gmae:");
            //while (true)
            //{
            //    Console.WriteLine("Please enter the number of rounds you want to play (Odd number only):");
            //    string roundsinput = Console.ReadLine();

            //    if (roundsinput == "quit")
            //    {
            //        break;
            //    }
            //    int rounds = int.Parse(roundsinput);
            //    if (rounds % 2 == 0)
            //    {
            //        Console.WriteLine("Error: PLease enter odd numbers only ");
            //        continue;
            //    }
            //    int userscore = 0;
            //    int aiscore = 0;
            //    for (int i = 0; i < rounds; i++)
            //    {
            //        Console.WriteLine("Rounds " + (i + 1) + " of " + rounds + " plesae enter rock,paper or scissors:");
            //        string userchoice = Console.ReadLine().ToLower();
            //        if (userchoice == "quit")
            //        {
            //            break;
            //        }
            //        Random random = new Random();
            //        string[] choices = { "rock", "paper", "scissors" };
            //        string aichoice = choices[random.Next(choices.Length)];
            //        Console.WriteLine("User Choice" + userchoice);
            //        Console.WriteLine("AI Choice" + aichoice);
            //        if (userchoice == aichoice)
            //        {
            //            Console.WriteLine("It is a Tie");
            //        }
            //        else if (userchoice == "rock" && aichoice == "scissor" || userchoice == "paper" && aichoice == "rock" || userchoice == "scissor" && aichoice == "paper")
            //        {
            //            userscore++;
            //            Console.WriteLine("User Wins");
            //        }
            //        else
            //        {
            //            aiscore++;
            //            Console.WriteLine("Ai Wins");
            //        }
            //    }
            //    Console.WriteLine("The Final Score is:");
            //    Console.WriteLine("User SCore is:" + userscore);
            //    Console.WriteLine("AI Score is:" + aiscore);
            //    if (userscore > aiscore)
            //    {
            //        Console.WriteLine("User WIns");
            //    }
            //    else if (userscore < aiscore)
            //    {
            //        Console.WriteLine("Ai Wins");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Draw");
            //    }
            //    Console.WriteLine("Would you like to continue type 'Yes' or enter 'quit' to exit the game");
            //    string ContinuePrompt = Console.ReadLine();
            //    if (ContinuePrompt == "quit")
            //    {
            //        break;
            //    }
            //}
            // NO 20
            //Console.WriteLine("Welcome to the Number Guessing Game: please enter 'quit' to exit the game at any time");
            //while (true)
            //{
            //    Console.WriteLine("Please enter number of attempts you want to play (Odd number only)L");
            //    string attemptsinput = Console.ReadLine();
            //    if (attemptsinput == "quit")
            //    {
            //        break;
            //    }
            //    int attempts = int.Parse(attemptsinput);
            //    if (attempts % 2 == 0)
            //    {
            //        Console.WriteLine("Error: Please the rounds in Odd number:");
            //        continue;
            //    }
            //    Random random = new Random();
            //    int magicnumber = random.Next(1, 21);
            //    int attemptsCount = 0;
            //    int guess;
            //    while (attemptsCount < attempts)
            //    {
            //        Console.WriteLine("Attempts " + (attemptsCount + 1) + " of " + attempts + " please enter the number between (1 to 20):");
            //        string userGuess = Console.ReadLine();
            //        if (userGuess == "quit")
            //        {
            //            break;
            //        }
            //        guess = int.Parse(userGuess);
            //        if (guess < 1 || guess > 20)
            //        {
            //            Console.WriteLine("Error: please enter guesses between 1 to 20:");
            //            continue;
            //        }
            //        attemptsCount++;
            //        if (guess == magicnumber)
            //        {
            //            Console.WriteLine("Your Guess is too High");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Your Guess is too Low");
            //        }
            //    }
            //        if (attemptsCount == attempts)
            //        {
            //            Console.WriteLine("Unfortunately, You've ran out of attempts! The Magic Number is: " + magicnumber);
            //        }
            //        Console.WriteLine("Would you like to continue enter 'yes' or enter 'quit' to exit the game");
            //        string ContinuePrompt = Console.ReadLine();
            //        if (ContinuePrompt == "quit")
            //        {
            //            break;
            //        }
            //}
            //Console.WriteLine("Welcome to Number Guessing Game; ");
            //while (true)
            //{
            //    Console.WriteLine("Please enter the number of attempts you want to guess: (Odd number only)");
            //    string attemptsinput = Console.ReadLine();
            //    if (attemptsinput == "quit")
            //    {
            //        break;
            //    }
            //    int attempts = int.Parse(attemptsinput);
            //    if (attempts % 2 == 0)
            //    {
            //        Console.WriteLine("Error: Number of attempts to be in odd number only");
            //        continue;
            //    }
            //    Random random = new Random();
            //    int magicNumber = random.Next(1, 21);
            //    int attemptsCount = 0;
            //    int guess;
            //    while (attemptsCount < attempts)
            //    {
            //        Console.WriteLine("Attempts" + (attemptsCount + 1) + " of " + attempts + ": Please enter your guess between (1 to 20) :");
            //        string UserGuess = Console.ReadLine();
            //        if (UserGuess == "quit")
            //        {
            //            break;
            //        }
            //        guess = int.Parse(UserGuess);
            //        if (guess < 1 || guess > 20)
            //        {
            //            Console.WriteLine("Invalid Guess: PLease enter number between 1 and 20 ");
            //            continue;
            //        }
            //        attemptsCount++;
            //        if (guess == magicNumber)
            //        {
            //            Console.WriteLine("Your Guess is too High");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Your Guess is too Low");
            //        }
            //    }
            //    if (attemptsCount == attempts)
            //    {
            //        Console.WriteLine("Unfortunately, You've ran out of attempts! The magic number is " + magicNumber + ".");
            //    }
            //    Console.WriteLine("Would You Like to Continue Type 'Yes' to Continue or Enter 'Quit' to Exit the Game");
            //    string ContinuePrompt = Console.ReadLine();
            //    if (ContinuePrompt == "Quit")
            //    {
            //        break;
            //    }
            //}
           
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
        // BI 15
        public static long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result += i;
            }
            return result;
        }
    }
}
