using System;
using System.Collections.Generic;
using System.Text;

namespace DuckGameBusinessLayer
{
    class CanNotFly : FlyBehavior
    {
        public string Fly()
        {
            return "I can't fly!!";
        }
    }
}
