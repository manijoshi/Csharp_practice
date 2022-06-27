using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Delegates
{
    public class DelegateClass
    {

        
        public static void Print(string msg, IEnumerable<int> list)
        {
            Console.Write(msg + " :   ");
            foreach (int num in list)
                Console.Write(num + "  ");
            Console.WriteLine();
            Console.WriteLine();
        }
        public static bool GreaterThanFive(int x)
        {
            return x > 5;
        }
        public static bool LesserThanFive(int x)
        {
            return x < 5;
        }
        public static bool AnythingMethod(int x)
        {
            return x != 0;
        }
        public static void Calculation()
        {
            List<int> list = new List<int>() { 0, 1, 2, 3, 21, 5, 16, 7, 81, 9 };

            // Find odd - Lambda Expression – without curly brackets
            IEnumerable<int> odd = list.Where(x => x % 2 == 1);
            Print("Odd", odd);

            // Find Even - Lambda Expression – with curly brackets
            IEnumerable<int> even = list.Where(x => { return x % 2 == 0; });
            Print("Even", even);

            // Find Prime – Anonymous Method
            IEnumerable<int> primes = list.Where(delegate (int x) {
                if (x <= 1)
                    return false;
                for (int i = 2; i <= x / 2; i++)
                    if (x % i == 0)
                        return false;
                return true;
            });
            Print("Primes", primes);

            // Find Prime Another – Lambda Expression
            IEnumerable<int> primesAnother = list.Where(x => {
                if (x <= 1)
                    return false;
                for (int i = 2; i <= x / 2; i++)
                    if (x % i == 0)
                        return false;
                return true;
            });
            Print("Primes Another", primesAnother);

            // Elements Greater Than Five – Method Group Conversion Syntax
            // use method group conversion (assigns a method to a delegate)
            Func<int, bool> Greater = GreaterThanFive;
            IEnumerable<int> greaterThanFive = list.Where(Greater);
            Print("Greater Than Five", greaterThanFive);

            //Lesser than Five
            Func<int, bool> Lesser = new Func<int,bool>(LesserThanFive);
            IEnumerable<int> lesserThanFive = list.Where(Lesser);
            Print("Lesser Than Five", lesserThanFive);

            //Find 3k
            Func<int, bool> Condition3k = new Func<int, bool>(x => x % 3 == 0);
            IEnumerable<int> list3k = list.Where(Condition3k);
            Print("3k", list3k);

            //Find 3k+1
            Func<int, bool> Condition3kPlus1 = new Func<int, bool>(delegate(int x)
            {
                 return x % 3 == 1;
            });
            IEnumerable<int> list3kplus1 = list.Where(Condition3kPlus1);
            Print("3k + 1", list3kplus1);

            // Find 3K + 2
            Func<int, bool> Condition3kPlus2 = x => x % 3 == 2;
            IEnumerable<int> list3kplus2 = list.Where(Condition3kPlus2);

            // Find Anything
            Func<int, bool> Anything = delegate (int x)
             {
                 return x != 0;
             };
            IEnumerable<int> anything = list.Where(Anything);
            Print("Anything", anything);

            // Find Anything
            Func<int, bool> AnotherAnything = AnythingMethod;
            IEnumerable<int> anythingAnother = list.Where(AnotherAnything);
            Print("Anything", anythingAnother);
        }

    }
}
