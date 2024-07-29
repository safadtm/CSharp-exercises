using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericDatabase<T>
    {
        public List<T> Items = new List<T>();

        public void Create(T item)
        {
            Items.Add(item);
        }

        public void Remove(T item)
        {
            Items.Remove(item);
        }

        public void Display()
        {
            Console.WriteLine("List of " + typeof(T).Name + "'s");

            Items.ForEach(x =>
            {
                Console.WriteLine(x);
            });
        }
    }
}
