namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Generics
             * Helps to decouple logic and data type
             * code reusability
             * create the logic in a very "Generic data type" then later
             * apply it to many data types
             */
           
            GenericDatabase<int> gidb = new GenericDatabase<int>();
            gidb.Create(23);
            gidb.Create(45);
            gidb.Display();


            GenericDatabase<string> gsdb = new GenericDatabase<string>();
            gsdb.Create("Rohan");
            gsdb.Create("Vivek");
            gsdb.Display();
        }
    }
}
