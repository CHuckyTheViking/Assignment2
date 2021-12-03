using Assignment2.StateCommandMemento.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Memento
{
    class DataMemento
    {
        private DataManager DataManager { get; set; }

        public DataMemento(DataManager dataManager)
        {
            DataManager = dataManager;
        }

        public void ResetAndTurnOff(bool serverOn)
        {
            DataManager.Reset(serverOn);
        }



    }
}
