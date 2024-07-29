namespace FileOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * File Operation - common methods
             * 1. WriteAllText() 
             * 2. ReadAllText() 
             * 3. Create()
             * 4. Delete()
             * 5. Exists()
             * 6. AppendText()
             * 7. Replace()
             * 8. Copy()
             */


            string contents = "My file content";
            File.WriteAllText("myfile.txt", contents);

            Console.WriteLine(File.ReadAllText("myfile.txt"));
        }   
    }
}
