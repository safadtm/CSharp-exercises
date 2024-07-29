namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Access Modifiers
             * 1. public - code is visible for all the classes
             * 2. private - code is visible only within the same class
             * 3. protected - code is visible within the same class or the classes which inherits from that class
             * 4. internal - code is only accessible within its own assesmbly
             */

            Student student = new Student();    
            Console.WriteLine(student.name);
            Console.WriteLine(student.GetAge());

            College1 c1 = new College1();
            Console.WriteLine(c1.GetLocation());


        }
    }
}
