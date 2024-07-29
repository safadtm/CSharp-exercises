namespace Methods
{
    internal class Program
    {

        static void SayHello()
        {
            Console.WriteLine("Hellooo");
        }

        static int LargestNum(int num1,int num2)
        {
            int result; // local variable to the method

            if (num1>num2) { 
                result = num1;
            }
            else
            {
                result = num2;
            }

            return result;
        }

        static void Main(string[] args)
        {
            /*
             * Methods
             * 
             * 
             * 
             */
            SayHello();
            SayHello();
            Console.WriteLine(LargestNum(156, 2));
        }
    }
}
