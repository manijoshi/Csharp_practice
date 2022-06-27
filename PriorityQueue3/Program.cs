using System;
using System.Collections.Generic;
using System.Linq;

namespace PriorityQueue3
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
                        IList<int> list1 = new List<int>();
                        IList<int> list2 = new List<int>();
                        IList<int> list3 = new List<int>();

                        list1.Add(4);
                        list1.Add(3);
                        list1.Add(2);
                        temp.Add(3, list1);

                        //list.Clear();
                        list2.Add(6);
                        list2.Add(5);
                        temp.Add(2, list2);   // if we clear list below, empty list2 will be inserted here

                        //list2.Clear();     // if we clear list here, it won't show up at key 2
                        list3.Add(7);
                        list3.Add(3);
                        temp.Add(1, list3);

                        //print given dictionary
                        Console.WriteLine("\nGiven list:");
                        foreach (var e in temp)
                        {
                            Console.Write("\n" + e.Key + ": ");

                            var abc = temp[e.Key];

                            for (int i = 0; i < abc.Count(); i++)
                            {
                                Console.Write(abc[i] + " ");
                            }

                        }


                        PriorityQueue<int> obj1 = new PriorityQueue<int>(temp);


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
                                    Console.WriteLine("Enter element:");
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