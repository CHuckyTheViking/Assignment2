using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter.Classes
{
    class AdapterService
    {
        private PrintingInts PrintingInts;

        public AdapterService()
        {
            PrintingInts = new();
        }

        public void Print(string nr)
        {
            PrintingInts.Print(int.Parse(nr));
        }
    }
}
