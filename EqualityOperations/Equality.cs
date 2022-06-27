using System;

namespace EqualityOperations
{
    public class Equality
    {
        public static void EqualityFunctionsAndOperators()
        {
            // equal(==) operator : can be applied on any datatype element
            int a = 12, b = 13;
            if (a == b)
            {
                Console.WriteLine("{0} equals {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} not equals {1}", a, b);
            }

            // .Equals() method : can be applied on strings only
            string str1 = "Hello";
            string str2 = "Hello";
            string str3 = "Hii";
            if (str1.Equals(str2))
            {
                Console.WriteLine("{0} equals {1}", str1, str2);

            }
            if (!(str1.Equals(str3)))
            {
                Console.WriteLine("{0} not equals {1}", str1, str2);
            }

            // ReferenceEquals(par1,par2)
            object obj1 = null;
            object obj2 = null;

            Console.WriteLine(ReferenceEquals(obj1, obj2));
            Console.WriteLine(ReferenceEquals(obj1, obj1));
            //Console.WriteLine(obj1.Equals(obj1));

        }
    }
}
