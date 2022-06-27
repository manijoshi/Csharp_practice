using System;
using System.Collections.Generic;
using System.Text;

namespace DuckGameBusinessLayer
{

    public class MallardDuck : Duck
    {

        public MallardDuck(string name, float weightt, int nwingss)
        {
            // Fly fast 
            this.flyBehavior = new FlyFast();

            // Quack Loud
            this.quackBehavior = new QuackLoud();
            this.Name = name;
            this.Weight = weightt;
            this.Nwings = nwingss;
        }
        override public string Display()
        {
            return "I'm Mallard Duck!!";
        }

    }
}
