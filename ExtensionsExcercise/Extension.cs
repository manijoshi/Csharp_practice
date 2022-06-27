using System;

namespace ExtensionsExcercise
{
    public static class Extension
    {
        public static bool IsOdd(this int num)
        {
            return num % 2 != 0 ? true : false;
        }
        public static bool IsEven(this int num)
        {
            return num % 2 == 0 ? true : false;
        }
        public static bool IsPrime(this int num)
        {
            int c = 0;
            for(int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    c += 1;
                }
            }
            return c == 0 ? true : false;
          
        }
        public static bool IsDivisibleBy(this int num1, int num2)
        {
            return num1 % num2 == 0 ? true : false;
        }
    }
}
