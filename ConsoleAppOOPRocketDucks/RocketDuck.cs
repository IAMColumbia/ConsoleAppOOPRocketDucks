using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOPRocketDucks
{
    public class RocketDuck : Models.Duck, IRocketable
    {
        public bool IsIgnited { get; set ; }

        public void Launch()
        {
            this.IsFlying = true;
            this.Fly();
        }
    }
}