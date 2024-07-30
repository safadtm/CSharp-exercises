using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetter
{
    class Student
    {
        public string name;
        private string gender;

        public Student(string cName, string cGender)
        {
            name = cName;
            Gender = cGender;
        }

        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (value == "Male" || value == "Female")
                {
                    gender = value;

                }
                else
                {
                    throw new ArgumentException("Invalid value supplied");
                }
            }
        }
    }
}
