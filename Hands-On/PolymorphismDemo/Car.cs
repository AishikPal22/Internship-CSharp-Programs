using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PolymorphismDemo
{
    public class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        public Car(int hp, string color)
        {
            HP = hp;
            Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Horsepower : " + HP);
            Console.WriteLine("Color : " + Color);
        }

        public void Repair()
        {
            Console.WriteLine("Car is repaired successfully!!");
        }

        public virtual void ShowRepair()
        {
            Console.WriteLine("Car is repaired successfully!!");
        }
    }
}
