using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        int sizeOfAnimal = 0;

        public int SizeOfAnimal { get => sizeOfAnimal; set => sizeOfAnimal = value; }

        public string breathing()
        {
            return "I'm Okay.";
        }
        public string move()
        {
            return "Go Go Go !";
        }
    }
}
