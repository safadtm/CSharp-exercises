using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOverridingMethods
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("All animals makes sound");
        }
    }

    public class Dog:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bow Bow!!");
        }
    }
}
