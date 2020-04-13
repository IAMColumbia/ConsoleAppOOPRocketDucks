using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOPRocketDucks.Models
{
    class Rocket : IFlyable, IRocketable
    {
        public int CurrentAltitiude { get; set; }
        public bool IsIgnited { get; set; }
        public bool IsFlying { get; set; } //Property

        public string Fly()
        {
            this.IsFlying = true;
            return string.Format("(0) is flying", this);
        }

        public string FlyUp()
        {
            this.CurrentAltitiude++;
            return this.Fly() + " currant Altitude" + this.CurrentAltitiude;
        }

        public string FlyDown()
        {
            this.CurrentAltitiude--;
            return $"{this.Fly()} current Altitiude {this.CurrentAltitiude}";
        }

        public void Launch()
        {
            this.IsIgnited = true;
        }
    }
}
