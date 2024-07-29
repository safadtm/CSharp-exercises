namespace BreakContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * break, continue
             * 
             * 
             */

            for (int i = 0;i<=10;i++)
            {
                Console.WriteLine(i);
                if (i==5)
                {
                    break;
                }
            }

            for (int j = 10; j <= 20; j++)
            {
                
                if (j == 15)
                {
                    continue;
                }
                Console.WriteLine(j);
            }
        }
    }
}
