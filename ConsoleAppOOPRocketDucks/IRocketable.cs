using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOPRocketDucks
{
    public interface IRocketable
    {
        bool IsIgnited { get; set; }

        void Launch();
    }
}