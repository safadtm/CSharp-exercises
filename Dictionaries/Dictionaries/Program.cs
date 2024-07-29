namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Dictionaries
             * 
             * 
             * 
             */

            Dictionary<string, long> phoneBook = new Dictionary<string, long>();

            phoneBook.Add("Steve",987456321);
            phoneBook["Paul"] = 456321;

            if (phoneBook.ContainsKey("Steve"))
            {
                Console.WriteLine("Steve number is " + phoneBook["Steve"]);
                Console.WriteLine(phoneBook.Count);
            }
        }
    }
}
