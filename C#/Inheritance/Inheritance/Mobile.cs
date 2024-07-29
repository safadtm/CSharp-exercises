using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Mobile // Parent class
    {
        public string os = "Andriod";

        public void MakeCalls()
        {
            Console.WriteLine("Any mobile can make calls");
        }
    }
}
