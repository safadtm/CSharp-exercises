namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello WOrld";
            Console.WriteLine(s);

            string s2 = "Escape \"Statement\"";
            Console.WriteLine(s2);

            string s3 = "C:\\Users\\DOTNET>"; // Escape sequence
            Console.WriteLine(s3);

            string s4 = @"C:\Users\DOTNET>"; // verbatim literals
            Console.WriteLine(s4);

            Console.WriteLine(s4.Length);
            Console.WriteLine(s4.ToUpper());
             Console.WriteLine(s4.ToUpper());
            Console.WriteLine(s4[0]);
            Console.WriteLine(s4[1]);

        }
    }
}
