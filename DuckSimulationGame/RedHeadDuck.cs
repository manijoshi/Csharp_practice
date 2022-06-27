using System;
using System.Collections.Generic;
using System.Text;

namespace DuckGameBusinessLayer
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck(string name, float weightt, int nwingss)
        {
            // Fly slow
            this.flyBehavior = new FlySlow();

            // Quack Mild
            this.quackBehavior = new MuteQuack();
            this.Name = name;
            this.Weight = weightt;
            this.Nwings = nwingss;
        }
        override public string Display()
        {
            return "I'm RedHead Duck!!";
        }
    }
}
