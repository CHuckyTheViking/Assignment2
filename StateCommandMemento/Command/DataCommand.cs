using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Command
{
    class DataCommand : ICommand
    {

        public IData Data { get; set; }
        public string DataText { get; set; }

        public DataCommand(IData data, string dataText)
        {
            Data = data;
            DataText = dataText;
        }

        public void Do()
        {
            Data.SaveData(DataText);
        }


    }
}
