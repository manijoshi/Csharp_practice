using System;
using System.Collections.Generic;

namespace PriorityQueue1
{
    public class Program
    {
        public static void Main()
        {
            //Console.WriteLine("Inside Exercise 8");

            bool counter = true;
            while (counter)
            {
                Console.WriteLine("\nEnter 1 to create priority queue");
                Console.WriteLine("Enter 2 to create priority queue with given input");
                Console.WriteLine("Enter 0 to exit");

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        PriorityQueue<int> obj = new PriorityQueue<int>();

                        bool innerCounter1 = true;
                        while (innerCounter1)
                        {
                            Console.WriteLine("\nEnter 1 to count elements in priority queue");
                            Console.WriteLine("Enter 2 to find specific element in priority queue");
                            Console.WriteLine("Enter 3 to remove element from priority queue");
                            Console.WriteLine("Enter 4 to add element in priority queue");
                            Console.WriteLine("Enter 5 to find the peak element");
                            Console.WriteLine("Enter 6 to find the highest priority");
                            Console.WriteLine("Enter 0 to exit");

                            int input1 = int.Parse(Console.ReadLine());

                            switch (input1)
                            {
                                case 1:
                                    int count = obj.Count();
                                    Console.WriteLine("Number of elements: {0}", count);
                                    break;

                                case 2:
                                    Console.WriteLine("Enter an element to be searched");
                                    int e = int.Parse(Console.ReadLine());

                                    if (obj.Contains(e))
                                    {
                                        Console.WriteLine("Priority Queue contains {0}\n", e);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Priority Queue does not contains {0}\n", e);
                                    }
                                    break;

                                case 3:
                                    int elementToBeRemoved = obj.Peek();
                                    obj.Dequeue();

                                    Console.WriteLine("{0} removed\n", elementToBeRemoved);
                                    break;

                                case 4:
                                    Console.WriteLine("Enter priority");
                                    int priority = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter the element");
                                    int element = int.Parse(Console.ReadLine());

                                    obj.Enqueue(priority, element);

                                    break;

                                case 5:
                                    int peak = obj.Peek();
                                    Console.WriteLine("Peak element = {0}\n", peak);
                                    break;

                                case 6:
                                    int highestPriority = obj.GetHighestPriority();
                                    Console.WriteLine("Highest Priority = {0}\n", highestPriority);
                                    break;

                                case 0:
                                    innerCounter1 = false;
                                    break;

                                default:
                                    Console.WriteLine("Invalid input");
                                    break;

                            }   // inner switch ends
                        }       // inner while ends
                        break;

                    case 2:
                        IDictionary<int, IList<int>> temp = new Dictionary<int, IList<int>>();
                        Console.WriteLine("Enter elements: ");

                        bool inputElementCounter = true;
                        while (inputElementCounter)
                        {
                            Console.WriteLine("\nEnter 1 to add element");
                            Console.WriteLine("Enter 0 to exit");

                            int option = int.Parse(Console.ReadLine());

                            switch (option)
                            {
                                case 1:
                                    Console.WriteLine("Enter priority");
                                    int priority = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Number of elements of given priority");
                                    int n = int.Parse(Console.ReadLine());

                                    // input list of elements
                                    IList<int> list = new List<int>();
                                    for (int i = 0; i < n; i++)
                                    {
                                        Console.WriteLine("Enter the element");
                                        int element = int.Parse(Console.ReadLine());
                                        list.Add(element);
                                    }

                                    // adding priority, list to temp
                                    temp.Add(priority, list);

                                    break;

                                case 0:
                                    inputElementCounter = false;
                                    break;

                                default:
                                    Console.WriteLine("Invalid input");
                                    break;
                            }
                        }


                        PriorityQueue<int> obj1 = new PriorityQueue<int>(temp);
                        //PriorityQueue<int> obj1 = new PriorityQueue<int>();
                        //obj1 = objTemp;

                        bool innerCounter2 = true;
                        while (innerCounter2)
                        {
                            Console.WriteLine("\nEnter 1 to count elements in priority queue");
                            Console.WriteLine("Enter 2 to find specific element in priority queue");
                            Console.WriteLine("Enter 3 to remove element from priority queue");
                            Console.WriteLine("Enter 4 to add element in priority queue");
                            Console.WriteLine("Enter 5 to find the peak element");
                            Console.WriteLine("Enter 6 to find the highest priority");
                            Console.WriteLine("Enter 0 to exit");

                            int input2 = int.Parse(Console.ReadLine());

                            switch (input2)
                            {
                                case 1:
                                    int count = obj1.Count();
                                    Console.WriteLine("Number of elements: {0}", count);
                                    break;

                                case 2:
                                    Console.WriteLine("Enter an element to be searched");
                                    int e = int.Parse(Console.ReadLine());

                                    if (obj1.Contains(e))
                                    {
                                        Console.WriteLine("Priority Queue contains {0}\n", e);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Priority Queue does not contains {0}\n", e);
                                    }
                                    break;

                                case 3:
                                    int elementToBeRemoved = obj1.Peek();
                                    obj1.Dequeue();

                                    Console.WriteLine("{0} removed\n", elementToBeRemoved);
                                    break;

                                case 4:
                                    Console.WriteLine("Enter priority");
                                    int priority = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter the element");
                                    int element = int.Parse(Console.ReadLine());

                                    obj1.Enqueue(priority, element);

                                    break;

                                case 5:
                                    int peak = obj1.Peek();
                                    Console.WriteLine("Peak element = {0}\n", peak);
                                    break;

                                case 6:
                                    int highestPriority = obj1.GetHighestPriority();
                                    Console.WriteLine("Highest Priority = {0}\n", highestPriority);
                                    break;

                                case 0:
                                    innerCounter2 = false;
                                    break;

                                default:
                                    Console.WriteLine("Invalid input");
                                    break;

                            }   // inner switch ends
                        }       // inner while ends
                        break;



                    case 0:
                        counter = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

            }
        }
    }
}
