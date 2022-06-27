using System;

namespace PrimeNumbers
{
    public class PrimeNumberClass
    {
        public static void PrimeNumber()
        {
            while (true)
            {
                Console.WriteLine("Enter 2 positive non-equal numbers");
                Console.Write("Enter num1: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter num2: ");
                int num2 = int.Parse(Console.ReadLine());
                if (num1 > num2)
                {
                    Console.WriteLine("\nRe-enter both the numbers");
                    Console.WriteLine("First number should be lesser than second number");
                    continue;
                }
                bool[] primes = new bool[num2 + 1];
                for (int i = 0; i <= num2; i++)
                {
                    primes[i] = true;
                }
                int p = 2;
                while (p * p <= num2)
                {
                    if (primes[p])
                    {
                        for (int i = p * p; i <= num2; i += p)
                        {
                            primes[i] = false;
                        }
                    }
                    p += 1;
                }
                for (int i = num1+1; i <= num2; i++)
                {
                    if (primes[i])
                    {
                        Console.Write(i + " ");
                    }
                }
                break;
            }

        }
    }
}
