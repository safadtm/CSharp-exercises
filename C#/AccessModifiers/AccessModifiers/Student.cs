using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
     class Student
    {
        public string name = "Safad";
        private int age = 20;
        protected string location = "Kochi";

        public int GetAge()
        {
            return age;
        }
    }

    class College1 : Student { 
       public string GetLocation()
        {

        return location; 
        }
    }
    
}
