using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.State
{
    class Server : IServerState
    {
        public IServerState ServerState { get; set; }

        public Server()
        {
            ServerState = new ServerOffState();
        }


        public void PowerSwitch()
        {
            
            if (ServerState is ServerOffState)
            {
                ServerState = new ServerOnState();
            }
            else
            {
                ServerState = new ServerOffState();
            }
            ServerState.PowerSwitch();
        }
    }
}
