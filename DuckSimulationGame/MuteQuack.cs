using System;
using System.Collections.Generic;
using System.Text;

namespace DuckGameBusinessLayer
{
    class MuteQuack : QuackBehavior
    {
        public string Quack()
        {
            return "I can't quack!!";
        }
    }
}
