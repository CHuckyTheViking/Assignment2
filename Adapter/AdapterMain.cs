using Assignment2.Adapter.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    class AdapterMain
    {
        public void Run()
        {
            // Skriv en adapter för ReturningStrings som kan konsumeras av PrintingInts           



            ReturningStrings returningStrings = new();
            
            AdapterService adapterService = new AdapterService();
            adapterService.Print(returningStrings.ReturnString());

            Console.ReadKey();
        }
    }
}
