﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.State
{
    class ServerOffState : IServerState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Turning Server Off");
        }

    }
}
