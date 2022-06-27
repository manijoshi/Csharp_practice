using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace PriorityQueue2
{
    public class PQInput : IPriority, IEquatable<PQInput>
    {
        public int Priority
        {
            get;
            set;
        }
        public int Data
        {
            get;
            set;
        }

        public bool Equals([AllowNull] PQInput other)
        {
            return this.Priority == other.Priority;
        }
    }
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

                        PriorityQueue<PQInput> obj = new PriorityQueue<PQInput>();

                        //PriorityQueue<MyInputType> obj = new PriorityQueue<MyInputType>();

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
                                    PQInput searchInput = new PQInput();
                                    Console.WriteLine("Enter an element to be searched");
                                    searchInput.Data = int.Parse(Console.ReadLine());

                                    if (obj.Contains(searchInput))
                                    {
                                        Console.WriteLine("Priority Queue contains {0}\n", searchInput);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Priority Queue does not contains {0}\n", searchInput);
                                    }
                                    break;

                                case 3:
                                    PQInput elementToBeRemoved = obj.Peek();
                                    obj.Dequeue();

                                    Console.WriteLine("{0} removed\n", elementToBeRemoved);
                                    break;

                                case 4:
                                    PQInput addInput = new PQInput();
                                    Console.WriteLine("Enter priority");
                                    addInput.Priority = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter the element");
                                    addInput.Data = int.Parse(Console.ReadLine());

                                    obj.Enqueue(addInput);

                                    break;

                                case 5:
                                    PQInput peak = obj.Peek();
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
                        List<PQInput> list = new List<PQInput>();

                        for (int i = 1; i <= 5; i++)
                        {
                            PQInput tempMember = new PQInput();
                            tempMember.Priority = i;
                            tempMember.Data = i;
                            list.Add(tempMember);
                        }

                        IEnumerable<PQInput> temp = list;

                        Console.WriteLine("\nGiven list is (Priority,Data):");
                        foreach (var num in temp)
                        {
                            Console.WriteLine("({0}, {1})", num.Priority, num.Data);
                        }
                        Console.Write("\n");

                        PriorityQueue<PQInput> obj1 = new PriorityQueue<PQInput>(temp);
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
                                    PQInput searchInput = new PQInput();
                                    Console.WriteLine("Enter an element to be searched");
                                    searchInput.Data = int.Parse(Console.ReadLine());

                                    if (obj1.Contains(searchInput))
                                    {
                                        Console.WriteLine("Priority Queue contains {0}\n", searchInput);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Priority Queue does not contains {0}\n", searchInput);
                                    }
                                    break;

                                case 3:
                                    PQInput elementToBeRemoved = obj1.Peek();
                                    obj1.Dequeue();

                                    Console.WriteLine("{0} removed\n", elementToBeRemoved);
                                    break;

                                case 4:
                                    PQInput addInput = new PQInput();
                                    Console.WriteLine("Enter priority");
                                    addInput.Priority = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter the element");
                                    addInput.Data = int.Parse(Console.ReadLine());

                                    obj1.Enqueue(addInput);

                                    break;

                                case 5:
                                    PQInput peak = obj1.Peek();
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
