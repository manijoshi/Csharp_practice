using System;
using System.Collections.Generic;
using System.Text;

namespace DuckGameBusinessLayer
{
    public class Program
    {
        public enum Types
        {
            Rubber = 1,
            Mallard,
            RedHead

        }
        public static void Main()
        {
            DuckBusinessLayer obj1 = new DuckBusinessLayer();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome :- Duck Simulator Game!!");
                Console.WriteLine("Press 1 to Create a duck");
                Console.WriteLine("Press 2 to Show details of duck");
                Console.WriteLine("Press 3 to Remove a duck");
                Console.WriteLine("Press 4 to Remove all ducks");
                Console.WriteLine("Press 5 to Show ducks in increasing order of their wings");
                Console.WriteLine("Press 6 to Show ducks in increasing order of their weights");
                Console.WriteLine("Press 0 to exit");
                int inp = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (inp)
                {
                    case 1:
                        Console.WriteLine("Which Duck you wanna create:-");
                        Console.WriteLine("Press 1 to create RubberDuck");
                        Console.WriteLine("Press 2 to create MallardDuck");
                        Console.WriteLine("Press 3 to create RedHeadDuck");
                        int opt = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Give duck a name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter weight of duck: ");
                        float weight = float.Parse(Console.ReadLine());
                        Console.Write("Enter no. of wings of duck: ");
                        int nwings = int.Parse(Console.ReadLine());
                        switch ((Types)opt)
                        {
                            case Types.Rubber:
                                obj1.CreateRubberDuck(name, weight, nwings);/////???????? redirect nhi ho rha .CreateRubberDuck pr
                                break;
                            case Types.Mallard:
                                //Console.Write("Enter weight of duck: ");
                                //float weight1 = float.Parse(Console.ReadLine());
                                //Console.Write("Enter no. of wings of duck: ");
                                //int nwings1 = int.Parse(Console.ReadLine());

                                obj1.CreateMallardDuck(name, weight, nwings);
                                break;
                            case Types.RedHead:
                                //Console.Write("Enter weight of duck: ");
                                //float weight2 = float.Parse(Console.ReadLine());
                                //Console.Write("Enter no. of wings of duck: ");
                                //int nwings2 = int.Parse(Console.ReadLine());

                                obj1.CreateRedHeadDuck(name, weight, nwings);
                                break;
                        }
                        break;
                    case 2:
                        obj1.ShowDuckDetails();
                        break;
                    case 3:

                        obj1.RemoveADuck();
                        break;
                    case 4:

                        obj1.RemoveAllDucks();
                        break;
                    case 5:

                        obj1.IncreasingByWeight();
                        break;
                    case 6:

                        obj1.IncreasingByWings();
                        break;
                    case 0:
                        flag = false;
                        break;

                }
            }
        }
    }
}
