using Assignment2.StateCommandMemento.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Command
{
    class DataManager
    {

        private Data Data { get; set; }
        private Server Server { get; set; }
        private List<ICommand> CommandList { get; set; }


        public DataManager()
        {
            Data = new();
            CommandList = new();
            Server = new();
        }

        public void Do()
        {
            var command = CommandList;
            if (command.Count != 0)
            {
                Console.WriteLine("Adding the commands from when server was off");
                foreach (var item in command)
                {
                    item.Do();
                }
                CommandList.Clear();
            }
            else
            {
                Console.WriteLine("No Command found");
            }
        }

        public void Reset(bool serverOn)
        {
            if (serverOn == true)
            {
                Server.PowerSwitch();
                Data.ResetAll();
                CommandList.Clear();
                Environment.Exit(0);
            }
            else
            {
                Data.ResetAll();
                CommandList.Clear();
                Environment.Exit(0);
            }
        }

        public void AddText(string dataText, bool serverOn)
        {
            ICommand command = new DataCommand(Data, dataText);
            if (serverOn == false)
                CommandList.Add(command);

            if (serverOn == true)
                command.Do();

        }

    }
}
