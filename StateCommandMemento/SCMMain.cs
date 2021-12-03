using Assignment2.StateCommandMemento.Command;
using Assignment2.StateCommandMemento.Memento;
using Assignment2.StateCommandMemento.State;
using System;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. !Använd Memento Pattern!
         */
        public void Run()
        {
            var dataManager = new DataManager();
            var dataMemento = new DataMemento(dataManager);
            Server server = new Server();
            bool serverOn = false;

            
            while (true)
            {
                Console.WriteLine("1: Server On/Off" +
                                               "\n2: Write Text to store on Server " +
                                               "\n3: Reset server data and turn the program off");


                var userinput = int.Parse(Console.ReadKey().KeyChar.ToString());
                switch (userinput)
                {
                    case 1:
                        server.PowerSwitch();
                        if (server.ServerState is ServerOnState)
                        {
                            serverOn = true;
                            dataManager.Do();
                        }

                        if (server.ServerState is ServerOffState)
                            serverOn = false;

                        
                        break;

                    case 2:
                        //kommando
                        Console.WriteLine("Enter the text that you want to save on Server");
                        var dataText = Console.ReadLine();

                        dataManager.AddText(dataText, serverOn);

                        break;

                    case 3:
                        dataMemento.ResetAndTurnOff(serverOn);
                        break;

                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }
    }
}