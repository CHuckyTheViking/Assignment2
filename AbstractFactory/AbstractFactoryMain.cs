using Assignment2.AbstractFactory.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class AbstractFactoryMain
    {
        // Skapa två fabriker som kan köra CreateAnimal() den ena fabriken ska skapa en hund och den andra en katt skapa sedan en abstract factory där man
        // får tillbaka en av de 2 fabrikerna beroende på en sträng parameter
        
        public void Run()
        {
            Start:
            Console.WriteLine("What do you want to add?\n1:Cat\n2:Dog");
            var choice = int.Parse(Console.ReadKey().KeyChar.ToString());
            if (choice == 1)
            {
                var factory = new AbstractFactoryFactory();
                var catFactory = factory.ChooseFactory("Cat");
                Console.WriteLine("\nWhat name does the Cat have?");
                var animal = catFactory.CreateAnimal(Console.ReadLine());
                if (animal != null)
                {
                    Console.WriteLine($"{animal.Name} was added!");
                }
                Console.ReadKey();
                Console.Clear();
                goto Start;
            }
            if (choice == 2)
            {
                var factory = new AbstractFactoryFactory();
                var dogFactory = factory.ChooseFactory("Dog");
                Console.WriteLine("\nWhat name does the Dog have?");
                var animal = dogFactory.CreateAnimal(Console.ReadLine());
                if (animal != null)
                {
                    Console.WriteLine($"{animal.Name} was added!");
                }
                Console.ReadKey();
                Console.Clear();
                goto Start;
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
            

        }
    }
}
