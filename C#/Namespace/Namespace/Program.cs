using MyNameSpaceOne;
using OuterNameSpace.MyNameSpaceTwo;

namespace MyNameSpaceOne
{
    class A
    {
        public void MyMethod()
        {
            Console.WriteLine("Message from MyNameSpaceOne class A");
        }
    }
}

namespace OuterNameSpace
{
    namespace MyNameSpaceTwo
    {
        class B
        {
            public void MyMethod()
            {
                Console.WriteLine("Message from MyNameSpaceTwo class A");
            }
        }
    }
}


namespace Namespace
{
    internal class Program
    {
         public static void Main(string[] args)
        {
           A a = new A(); 
            a.MyMethod();

            B b = new B();
            b.MyMethod();
        }
    }
}
