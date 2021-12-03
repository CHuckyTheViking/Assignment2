using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Facade.Classes
{
    class WordFacade
    {

        public List<Word> Words { get; set; }
        public WordFacade()
        {
            Words = new();
        }

        internal void AddWord(string wordString)
        {
            Words.Add(new Word(wordString));
        }


    }
}
