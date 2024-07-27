namespace DecisionMaking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Decision Making
             * if
             * if else
             * if else if else
             * nestef if
             */

            int age = 20;
            bool isBlind = true;
            if (age>18)
            {
                Console.WriteLine("You can apply for driving license");
            }else if (age==18)
            {
                if (isBlind==true) {
                    Console.WriteLine("You cannot drive");
                }
                Console.WriteLine("You can start learning driving");
            }
            else
            {

                Console.WriteLine("You must be atleast 18 to aplly for a license");
            }

        }
    }
}
