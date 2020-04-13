using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOPRocketDucks.Models
{
    public class Duck : IFlyable, IQuackable
    {
        public string DuckSound;
        public bool IsFlying { get; set; }

        public int CurrentAltitiude { get ; set ; }
      
        public Duck()
        {
            this.DuckSound = "Quack";
            this.IsFlying = false;
        }

        public string Fly()
        {
            this.IsFlying = true;
            return string.Format("(0) is flying", this);
        }

        public string Quack()
        {
            return this.DuckSound;
        }

        
        public string FlyUp()
        {
            throw new NotImplementedException();
        }

        public string FlyDown()
        {
            throw new NotImplementedException();
        }
    }
}
