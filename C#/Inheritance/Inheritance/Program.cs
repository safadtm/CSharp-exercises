namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*
            * OOPS
            * Inheritance
            */

            Andriod andriod = new Andriod();
            andriod.os = "ios";
            andriod.MakeCalls();
            Console.WriteLine(andriod.os);
        }

    }
}
