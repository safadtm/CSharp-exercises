namespace Structs
{
    internal class Program
    {
        struct Student
        {
            
            public string name;
            public int marks;

            public Student(string name, int marks) { 
               this.name = name;
                this.marks = marks;
            
            }

            public void DisplayStudent()
            {
                Console.WriteLine("Name : {0}, Mark : {0}",name,marks);
            }
        }

        static void Main(string[] args)
        {
            Student s1=new Student("Safad",70);
           
            s1.DisplayStudent();
        }
    }
}
