﻿using Assignment2.AbstractFactory.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{

    class Cat : ICat, IAnimal
    {
        public Cat(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

    }
}
