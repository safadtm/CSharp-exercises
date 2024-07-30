namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exception handling
             * try catch
             * finally - block of code which runs finally whether error occurs or not
             */
            try
            {
                int[] nums = { 1, 4, 5, 6, 7, 9 };
                Console.WriteLine(nums[10]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally {
                Console.WriteLine("The final block executed");
            }
        }
    }
}
