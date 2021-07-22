using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Cat : Animal
    {
        string name;

        public string Name { get => name; set => name = value; }

        public string cry()
        {
            return "Meowwwwww!";
        }

        public string move()
        {
            return "Super Run!";
        }
    }
}
