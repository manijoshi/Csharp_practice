using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DuckGameBusinessLayer
{
    public class DuckBusinessLayer
    {
        public List<Duck> ducks = new List<Duck>();
        public void CreateMallardDuck(string name, float weight, int nwings)
        {
            Duck mallard = new MallardDuck(name, weight, nwings);
            ducks.Add(mallard);
            Console.WriteLine("Duck created successfully!!\n");
        }
        public void CreateRubberDuck(string name, float weight, int nwings)
        {
            Duck rubber = new RubberDuck(name, weight, nwings);
            ducks.Add(rubber);
            Console.WriteLine("Duck created successfully!!\n");
        }
        public void CreateRedHeadDuck(string name, float weight, int nwings)
        {
            Duck redHead = new RedHeadDuck(name, weight, nwings);
            ducks.Add(redHead);
            Console.WriteLine("Duck created successfully!!\n");
        }
        public void ShowDuckDetails()
        {
            //ducks.ForEach((e) => Console.WriteLine(e.name + " " + e.Weight + " " + e.Nwings));
            if (ducks.Count == 0) Console.WriteLine("Duck list is empty!!\n");
            else
            {
                int c = 0;
                Console.Write("Enter duck name to get details: ");
                string name = Console.ReadLine();
                foreach (Duck duck in ducks)
                {
                    if (duck.Name == name.ToLower())
                    {
                        Console.WriteLine(duck.Display());
                        Console.WriteLine("Name: " + duck.Name);
                        Console.WriteLine("Weight: " + duck.Weight);
                        Console.WriteLine("No. of wings: " + duck.Nwings);
                        Console.WriteLine(duck.PerformQuack());
                        Console.WriteLine(duck.PerformFly());
                        Console.WriteLine();
                        c++;
                        break;
                    }
                }
                if (c == 0)
                {
                    Console.WriteLine("No such duck in the list");
                }
            }
        }
        public void RemoveADuck()
        {
            if (ducks.Count == 0) Console.WriteLine("Duck list is empty!!!\n");
            else
            {
                int c = 0;
                Console.Write("Enter duck name you wanna delete: ");
                string name = Console.ReadLine();
                foreach (Duck duck in ducks)
                {
                    if (duck.Name == name)
                    {
                        ducks.Remove(duck);
                        Console.WriteLine("Duck deleted successfully!!!\n");
                        c++;
                        break;
                    }
                }
                if (c == 0) Console.WriteLine("No such duck in the list, Enter valid name");

            }
        }
        public void RemoveAllDucks()
        {
            if (ducks.Count == 0) Console.WriteLine("Duck list is already empty!!\n");
            else
            {
                ducks.Clear();
                Console.WriteLine("Ducks deleted successfully!!\n");
            }
        }
        public void IncreasingByWeight()
        {

            if (ducks.Count == 0) Console.WriteLine("Duck list is empty!!\n");
            else
            {
                var increasingWeightOrder = ducks.OrderBy(d => d.Weight).Select(l => l.Name).ToList();
                Console.WriteLine(string.Join(" < ", increasingWeightOrder));
                Console.WriteLine();
            }
            //increasingWeightOrder.ForEach(du => Console.Write(du.Name+" "));

        }

        public void IncreasingByWings()
        {
            if (ducks.Count == 0) Console.WriteLine("Duck list is empty!!\n");
            else
            {
                var increasingWingsOrder = ducks.OrderBy(d => d.Nwings).Select(w => w.Name).ToList();
                Console.WriteLine(string.Join(" < ", increasingWingsOrder));
                Console.WriteLine();
            }
        }
    }
}

