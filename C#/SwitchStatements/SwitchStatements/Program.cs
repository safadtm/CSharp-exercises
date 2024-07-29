namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * switch statements
             * 
             * 
             */
            int number = 121;
            switch (number%2)
            {
                case 0:
                    Console.WriteLine("Number is even");
                    break;
                case 1:
                    Console.WriteLine("Number is odd");
                    break;
                    default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}
