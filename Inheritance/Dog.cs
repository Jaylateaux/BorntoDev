using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Dog : Animal
    {
        string name;

        public string Name { get => name; set => name = value; }

        private string bark()
        {
            return "Woef Woef!";
        }
    }
}
