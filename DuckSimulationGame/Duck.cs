using System;

namespace DuckGameBusinessLayer
{
    public abstract class Duck
    {
        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;
        private string name;
        private float weight;
        private int nwings;

        //Now
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int Nwings
        {
            get { return nwings; }
            set { nwings = value; }
        }
        public Duck()
        {

        }
        public abstract string Display();
        public string PerformFly()
        {
            return this.flyBehavior.Fly();
        }
        public string PerformQuack()
        {
            return this.quackBehavior.Quack();
        }
        /*public void SetFlyBehavior(FlyBehavior fb)
        {
            this.flyBehavior = fb;
        }
        */
        /*public void SetQuackBehavior(QuackBehavior qb)
        {
            this.quackBehavior = qb;
        }*/


    }
}
