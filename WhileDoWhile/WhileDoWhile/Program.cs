namespace WhileDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * While, Do While
             * 
             * 
             */

            int i = 0;
            while (i<5)
            {
                Console.WriteLine(i);
                i = i + 2;
            }

            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 5);
        }
    }
}
