namespace ClassObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*
            * OBJECT ORIENTED PROGRAMMING - INTRODUCTION
            * CLASS & OBJECTS
            * class - Fruit
            * objects - apple, orange etc
            */

            Fruit apple =  new Fruit();
            apple.color = "Red";
            apple.name = "Apple";
            apple.DisplayName();
            Console.WriteLine(apple.color);

            Fruit  orange=new Fruit();
            orange.color = "Orange";
            orange.name = "Orange";
            orange.DisplayName();
            Console.WriteLine(orange.color);


            Car ferrari = new Car();
            ferrari.color = "Yellow";
            ferrari.price = 155500.00;
            Console.WriteLine(ferrari.color);
            Console.WriteLine(ferrari.price);
        }
    }
}
