﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Print()
        {
            Console.WriteLine(FirstName+" "+LastName);
        }
    }
}
