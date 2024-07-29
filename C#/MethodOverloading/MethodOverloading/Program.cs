namespace MethodOverloading
{
    internal class Program
    {

        static int add(int x, int y) {
        return x + y;
        }

        static double add(double x, double y)
        {
            return x + y;
        }

        static int add(int x, int y,int z)
        {
            return x + y+z;
        }

        static void Main(string[] args)
        {
            /*
             * Method Overloading
             * Multiple methods can have the same name with different parameters
             */
            Console.WriteLine(add(56,44));
            Console.WriteLine(add(45.36, 44.21));
            Console.WriteLine(add(100, 200,300));
        }
    }
}
