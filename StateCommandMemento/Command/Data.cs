using Assignment2.StateCommandMemento.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Command
{
    class Data : IData
    {
        public string DataText { get; set; }

        public void SaveData(string dataText)
        {
            Console.WriteLine($"Saving Text:  {dataText} to Server");
        }
        public void ResetAll()
        {
            Console.WriteLine("Removing all data from server and turning server and program off");
        }

        public DataMemento CreateMemento(DataManager dataManager)
        {
            return new DataMemento(dataManager);
            
        }

    }
}
