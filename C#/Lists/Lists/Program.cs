namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lists
             * 1. Adding elements to list
             * 2. Removing elements to list
             * 3. Concatinating list
             * 4. Add an array to the list
             */

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

           
            Console.WriteLine(numbers.ElementAt(0));
            Console.WriteLine(numbers.ElementAt(1));
            Console.WriteLine(numbers.ElementAt(2));

            numbers.Remove(2);

            List<int> numbers2 = new List<int>();
            numbers2.Add(10);
            numbers2.Add(20);
            numbers2.Add(30);

            numbers.AddRange(numbers2); // Concatination
            Console.WriteLine(numbers.ElementAt(0));
            Console.WriteLine(numbers.ElementAt(1));
            Console.WriteLine(numbers.ElementAt(2));
            Console.WriteLine(numbers.ElementAt(3));
            Console.WriteLine(numbers.ElementAt(4));
           

            Console.WriteLine("Numbers count : "+numbers.Count);
            int[] array = new int[] { 200, 300, 400 };
            numbers.AddRange(array);

            Console.WriteLine(numbers.ElementAt(0));
            Console.WriteLine(numbers.ElementAt(1));
            Console.WriteLine(numbers.ElementAt(2));
            Console.WriteLine(numbers.ElementAt(3));
            Console.WriteLine(numbers.ElementAt(4));
            Console.WriteLine(numbers.ElementAt(5));
            Console.WriteLine(numbers.ElementAt(6));
            Console.WriteLine(numbers.ElementAt(7));

            List<string> abc = new List<string>();
            abc.Add("a");
            abc.Add("b");
            Console.WriteLine(abc.ElementAt(0));
            Console.WriteLine(abc.ElementAt(1));
        }
    }
}
