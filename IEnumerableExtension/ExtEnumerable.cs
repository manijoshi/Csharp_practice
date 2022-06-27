using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerableExtension
{
    public static class ExtEnumerable
    {
        public delegate bool Condition<T>(T n);
        // CustomAll
        public static bool CustomAll<T> (this IEnumerable<T> list, Func<T,bool> condition)
        {
            return list.All(condition);
        }
        // CustomAny
        public static bool CustomAny<T>(this IEnumerable<T> list, Func<T, bool> condition)
        {
            return list.Any(condition);
        }
        //CustomMax
        public static TResult CustomMax<T,TResult>(this IEnumerable<T> list, Func<T,TResult> function)
        {
            return list.Max(function);
        }
        //CustomMin
        public static TResult CustomMin<T,TResult>(this IEnumerable<T> list,Func<T,TResult> function)
        {
            return list.Min(function);
        }
        // CustomWhere
        public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> list,Func<T,bool> condition)
        {
            return list.Where(condition);
        }
        //CustomSelect
        public static IEnumerable<TResult> CustomSelect<T,TResult>(this IEnumerable<T> list, Func<T,TResult> function)
        {
            return list.Select(function);
        }

    }
}
