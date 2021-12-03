using Assignment2.Facade.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Facade
{
    class FacadeMain
    {
       public void Run()
        {
            // Write a facade to make it easier to save and load words
            WordFacade WordFacade = new WordFacade();

            while (true)
            {
                Console.WriteLine("1: Store word" +
                            "\n2: load all words and write them out");

                var choice = int.Parse(Console.ReadKey().KeyChar.ToString());

                if (choice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\nPlease write a word shorter than 10 letters");
                    string input = Console.ReadLine();
                    if (input.Length > 10)
                    {
                        Console.WriteLine("Error, word too long");
                        Console.ReadKey(true);
                    }
                    else
                    {
                        WordFacade.AddWord(input);
                    }

                }
                if (choice == 2)
                {
                    Console.Clear();
                    if (WordFacade.Words.Count > 0)
                    {
                        foreach (var word in WordFacade.Words)
                        {
                            Console.WriteLine($"\n Word: {word.WordString}");
                        }
                    }
                }
            }
        }
    }
}
