using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOPRocketDucks.Models
{
    public interface IFlyable
    {
        int CurrentAltitiude { get; set; }
        bool IsFlying { get; set; }

        string Fly();
        string FlyUp();
        string FlyDown();
    }
}
