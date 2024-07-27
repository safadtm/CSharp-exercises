namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Operators
             * Assignment operator =
             * Arithmetic operators +,-,*,/,%
             * Comparison operator ==,!=,>,<,<=,>=
             * Conditional operators &&,||
             * Ternary operator ? :
             */

            int number1 = 100;
            int number2 = 25;

            if (number1!=number2||number1!=100)
            {
                Console.WriteLine("Condition 1 is true");
            }
            else
            {
                Console.WriteLine("Condition 2 is true");
            }

            bool isNumberOneIsLarger = number1 > number2 ? true : false;

            Console.WriteLine(isNumberOneIsLarger);
        }
    }
}
