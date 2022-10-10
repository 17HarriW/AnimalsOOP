using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog John = new Dog();
            Hedgehog Brian = new Hedgehog();

            John.Fetch();
            John.Eat();
            John.Roll();
            John.Bark();

            Brian.Squeak();
            Brian.Eat();
        }
    }
}
