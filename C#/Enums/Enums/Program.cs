namespace Enums
{
    internal class Program
    {

        public enum Color
        {
            Red = 100,
            Green,
            Blue,
            MainColor = Red
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Color.Red);
            Console.WriteLine(Color.Green);
            Console.WriteLine(Color.Blue);
            Console.WriteLine(Color.MainColor);
            Console.WriteLine((int)Color.Red);
            Console.WriteLine((int)Color.Green);
            Console.WriteLine((int)Color.Blue);
            Console.WriteLine((int)Color.MainColor);
        }
    }
}
