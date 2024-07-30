using System.Runtime.InteropServices;
using System.Text;

namespace StringsVsStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * String
             */
            string msg = "Hello World";
            GCHandle gch = GCHandle.Alloc(msg, GCHandleType.Pinned);    
            IntPtr pObj = gch.AddrOfPinnedObject();
            Console.WriteLine($"Memory address str with first value:{pObj}");
            
            msg += "hi";
            gch = GCHandle.Alloc(msg,GCHandleType.Pinned);
            pObj = gch.AddrOfPinnedObject();
            Console.WriteLine($"Memory address str with append value:{pObj}");



            /*
             * String builder
             * 
             */

            StringBuilder sb = new StringBuilder("");
            sb.Append("Hello World");
            gch = GCHandle.Alloc(sb, GCHandleType.Pinned);
            pObj = gch.AddrOfPinnedObject();
            Console.WriteLine($"Memory address str with append value:{pObj}");

            sb.Append("hai");
            gch = GCHandle.Alloc(sb, GCHandleType.Pinned);
            pObj = gch.AddrOfPinnedObject();
            Console.WriteLine($"Memory address str with append value:{pObj}");

        }
    }
}
