namespace PolymorphismOverridingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * OOPS
             * Polymorhism and Overriding Methods 
             */

            Animal animal = new Animal();
            animal.MakeSound();

            Animal dog = new Dog();
            dog.MakeSound();

                 
        }
    }
}
