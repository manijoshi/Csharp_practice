using ExtensionsExcercise;
using System;
using System.Collections.Generic;

namespace MainProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag1 = true;
            while (flag1)
            {
                Console.WriteLine("1. Conversions");
                Console.WriteLine("2. Equality Operations");
                Console.WriteLine("3. Prime Numbers");
                Console.WriteLine("4. Equipment Inventory");
                Console.WriteLine("5. Duck Simulation Game");
                Console.WriteLine("6. Priority Queue1");
                Console.WriteLine("7. Priority Queue2");
                Console.WriteLine("8. Priority Queue3");
                Console.WriteLine("9. Extensions");
                Console.WriteLine("10. Delegates");
                Console.WriteLine("11. Extensions on IEnumerable Methods");
                Console.WriteLine("12. Product-Inventory");
                Console.WriteLine("13. Observable Collections");
                Console.WriteLine("14. File Operations");
                Console.WriteLine("15. Exception Handling");
                Console.WriteLine("0 to exit");
                int exp = int.Parse(Console.ReadLine());
                switch (exp)
                {
                    case 1:
                        Conversions.ConversionOperations.TypeConversion();
                        break;
                    case 2:
                        EqualityOperations.Equality.EqualityFunctionsAndOperators();
                        break;
                    case 3:
                        PrimeNumbers.PrimeNumberClass.PrimeNumber();
                        break;
                    case 4:
                        EquipmentInventory.Program.Main();
                        break;
                    case 5:
                        DuckGameBusinessLayer.Program.Main();
                        break;
                    case 6:
                        PriorityQueue1.Program.Main();
                        break;
                    case 7:
                        //PriorityQueue2.Program.Main();
                        break;
                    case 8:
                        PriorityQueue3.Program.Main();
                        break;
                    case 9:
                        bool flag = true;
                        while (flag)
                        {
                            Console.WriteLine("Enter 1 to perform IsOdd() operation");
                            Console.WriteLine("Enter 2 to perform IsEven() operation");
                            Console.WriteLine("Enter 3 to perform IsPrime() operation");
                            Console.WriteLine("Enter 4 to perform IsDivisibleBy() operation");
                            Console.WriteLine("Enter 0 to perform Exit operation");
                            int n = int.Parse(Console.ReadLine());
                            switch (n)
                            {
                                case 1:
                                    Console.Write("Enter a number: ");
                                    int num = int.Parse(Console.ReadLine());
                                    Console.WriteLine(num + " is Odd : {0}", (num.IsOdd()));
                                    break;
                                case 2:
                                    Console.Write("Enter a number: ");
                                    int num1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine(num1 + " is Even : {0}", (num1.IsEven()));
                                    break;
                                case 3:
                                    Console.Write("Enter a number: ");
                                    int num2 = int.Parse(Console.ReadLine());
                                    Console.WriteLine(num2 + " is Prime : {0}", (num2.IsPrime()));
                                    break;
                                case 4:
                                    Console.Write("Enter a numerator: ");
                                    int numerator = int.Parse(Console.ReadLine());
                                    Console.Write("Enter a denominator: ");
                                    int denominator = int.Parse(Console.ReadLine());
                                    Console.WriteLine(numerator + " is divisble by " + denominator + " : {0}", (numerator.IsDivisibleBy(denominator)));
                                    break;
                                case 0:
                                    flag = false;
                                    break;
                            }
                        }
                        break;
                    case 10:
                        Delegates.DelegateClass.Calculation();
                        break;
                    case 11:
                        IEnumerableExtension.MainClass obj = new IEnumerableExtension.MainClass();
                        obj.Main();
                        break;
                    case 12:
                        ProductInventory.Program.Main();
                        break;
                    case 13:
                        ObservableCollectionExcercise.ObservableCollectionEvents.Main();
                        break;
                    case 14:
                        FileOperation.Program.Main();
                        break;
                    case 15:
                        ExceptionHandling.Program.MathsGame();
                        break;
                    case 0:
                        flag1 = false;
                        break;
                }
            }
        }
    }
}