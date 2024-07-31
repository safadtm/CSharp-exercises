namespace AnonymousMethod
{
    internal class Program
    {
        public delegate int SumDelegate(int x,int y); 

        static void Main(string[] args)
        {
            SumDelegate sd = delegate (int x,int y) { return x + y; };

            Console.WriteLine(sd(200,300));
        }
    }
}
