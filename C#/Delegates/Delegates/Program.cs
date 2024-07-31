namespace Delegates
{
    internal class Program
    {
        delegate int ChangeNumber(int n);

        static void Main(string[] args)
        {
            Console.WriteLine(Add10(20));
            Console.WriteLine(Multiply10(100));

            ChangeNumber dele1 = new ChangeNumber(Add10);
            Console.WriteLine(dele1.Invoke(20));

            ChangeNumber dele2 = new ChangeNumber(Multiply10);
            Console.WriteLine(dele2.Invoke(100));
            Console.WriteLine(dele2(100));
        }
        static int Add10(int n)
        {
            return n + 10;
        }

        static int Multiply10(int n)
        {
            return n * 10;
        }

    }
}
