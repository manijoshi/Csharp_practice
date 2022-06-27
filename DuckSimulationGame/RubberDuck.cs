using System;
using System.Collections.Generic;
using System.Text;

namespace DuckGameBusinessLayer
{
    public class RubberDuck : Duck
    {

        public RubberDuck(string name, float weightt, int nwingss)
        {
            // don't fly
            this.flyBehavior = new CanNotFly();

            // Quack Loud
            this.quackBehavior = new Squeak();

            this.Name = name;
            this.Weight = weightt;
            this.Nwings = nwingss;
        }
        override public string Display()
        {
            return "I'm Rubber Duck!!";
        }
    }
}
