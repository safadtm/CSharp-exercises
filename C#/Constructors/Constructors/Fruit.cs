using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Fruit
    {
        public string color;
        public string name;
        public int price;

        public Fruit(string FruitColor, string FruitName) {
            color = FruitColor;
            name = FruitName;
        }

        public Fruit(string FruitColor, string FruitName,int FruitPrice)
        {
            color = FruitColor;
            name = FruitName;
            price = FruitPrice;
        }

        public void DisplayName() {
            Console.WriteLine("Fruit Name : "+name);
        }

        public void DisplayColor()
        {
            Console.WriteLine("Fruit Color : "+color);
        }

        public void DisplayPrice()
        {
            Console.WriteLine("Fruit Price : " + price);
        }
    }
}
