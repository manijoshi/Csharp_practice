using System;
using System.Collections.Generic;
using System.Text;

namespace IEnumerableExtension
{
    public class MainClass
    {
       public static void Print<T>(IEnumerable<T> list)
        {
            foreach (T ele in list)
                Console.Write(ele + " ");
            Console.WriteLine();
        }
        public void Main()
        {
            IEnumerable<int> list = new List<int>() { 0, -4, 2, 5, 6, -8, 4, 7, 12, 34 };
            Console.WriteLine(list.CustomAll(n => n > 0));
            Console.WriteLine(list.CustomAny(n => n == 0));
            Console.WriteLine(list.CustomMax(n => 2*n));
            Console.WriteLine(list.CustomMin(n => 2*n));
            IEnumerable<int> whereEnum = list.CustomWhere(n => n % 2 == 1);
            
            IEnumerable<double> selectEnum = list.CustomSelect(n => 0.5 * n);
            Print(selectEnum);
        }
    }
}
