namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * OOPS
             * Constructors
             *
             */
       
           Fruit mango = new Fruit("Yellow","Mango");

            mango.DisplayName();
            mango.DisplayColor();

            Fruit apple = new Fruit("Red", "Apple",30);

            apple.DisplayName();
            apple.DisplayColor();
            apple.DisplayPrice();

            Fruit pineapple = new Fruit("Yellow", "Pineapple", 60);

            pineapple.DisplayName();
            pineapple.DisplayColor();
            pineapple.DisplayPrice();
        }   
    }
}
