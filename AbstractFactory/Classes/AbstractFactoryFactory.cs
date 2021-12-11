using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory.Classes
{
    class AbstractFactoryFactory
    {

        public AbstractFactoryFactory()
        {

        }

        internal IFactory ChooseFactory(string type)
        {
            if (type == "Cat")
                return new CatFactory();

            if (type == "Dog")
                return new DogFactory();
           
            return null;
        }

    }
}
