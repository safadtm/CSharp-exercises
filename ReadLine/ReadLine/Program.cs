namespace ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello "+name); // String concatenation
            Console.WriteLine("Hello {0}",name); // Composite formatting
            Console.WriteLine($"Hello {name}"); // String interpolation 

        }
    }
}
