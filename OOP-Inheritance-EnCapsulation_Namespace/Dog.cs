using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Inheritance_EnCapsulation_Namespace
{
    class Dog:Animal
    {
        public Dog()
        {
            name = "Rex";
            Console.WriteLine(name);
            name = "Jack";
            Console.WriteLine(name);
        }
    }
}
