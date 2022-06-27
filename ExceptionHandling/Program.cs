using System;

namespace ExceptionHandling
{
    class InvalidNumberException : Exception
    {
        public InvalidNumberException(string message) : base(message) { }
    }
    public class Program
    {
        public static void MathsGame()
        {
            int num;
            int chances = 5;
            int timesPlayed = 0;
            while (timesPlayed < chances)
            {
                try
                {
                    Console.Write("Enter a number from 1-5: ");
                    string input = Console.ReadLine();
                    // if user entered wrong input
                    if (!UserInputIsCorrect(input, 1, 5, 0, false))
                    {
                        num = -1;
                    }
                    else
                    {
                        int.TryParse(input, out num);
                        timesPlayed++;
                        if (num == 1)
                        {
                            getAnswer("Enter even number: ", num);
                        }
                        else if (num == 2)
                        {
                            getAnswer("Enter an odd number: ", num);
                        }
                        else if (num == 3)
                        {
                            getAnswer("Enter a prime number: ", num);
                        }
                        else if (num == 4)
                        {
                            getAnswer("Enter a negative number: ", num);
                        }
                        else if (num == 5)
                        {
                            getAnswer("Enter zero: ", num);
                        }
                    }
                }
                catch (InvalidNumberException e)
                {
                    Console.WriteLine(e.Message);
                    num = -1;
                }
            }
            Console.WriteLine("\nNo more chances, you've played 5 times.\n");
            Console.ReadLine();

        }
        static void getAnswer(string message, int method)
        {
            int minValue = -999999;
            int maxValue = 999999;
            Console.Write(message);
            string input = Console.ReadLine();
            if (UserInputIsCorrect(input, minValue, maxValue, 0, false))
            {
                if (UserInputIsCorrect(input, minValue, maxValue, method, true))
                {
                    Console.WriteLine("Success!!! correct input");
                }
            }
        }

        // if prime 
        static bool IsPrime(int num)
        {
            if (num == 1) return false;
            if (num == 2) return true;
            for(int i = 2; i <= Math.Ceiling(Math.Sqrt(num)); ++i)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        // user input is correct or not
        static bool UserInputIsCorrect(string input,int min,int max,int method,bool isNextFunctions)
        
        {
            if (!isNextFunctions)
            {
                int num = -1;
                if (!int.TryParse(input, out num))
                {
                    throw new InvalidNumberException(string.Format("Error: enter a number from {0} - {1}.", min, max));

                }
                else
                {
                    if (num < min || num > max)
                    {
                        throw new InvalidNumberException(string.Format("Error: enter number from {0} - {1}.", min, max));
                    }

                }
                return true;
            }
            else
            {
                int num = -1;
                int.TryParse(input, out num);
                if (method == 1)
                {
                    if (num % 2 == 0) return true;
                    else throw new InvalidNumberException("\nIt is not an Even number. Try again!!\n");
                }
                if (method == 2)
                {
                    if (num % 2 == 1) return true;
                    else throw new InvalidNumberException("\nIt is not an Odd number. Try again!!\n");

                }
                if (method == 3)
                {
                    if (IsPrime(num)) return true;
                    else throw new InvalidNumberException("\nIt is not a Prime number. Try again!!\n");
                }
                if(method == 4)
                {
                    if (num < 0) return true;
                    else throw new InvalidNumberException("\nIt is not a negative number.Try again.\n");
                }
                if (method == 5)
                {
                    if (num == 0) return true;
                    else throw new InvalidNumberException("\nIt is not a zero number. Try again.\n");
                }
                return false;
            }
            
        }
        

    }
}
