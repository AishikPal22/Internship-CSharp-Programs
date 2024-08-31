using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    public class BMW : Car
    {
        private string brand = "BMW";

        public string Model { get; set; }

        public BMW(int hp, string color, string model) : base(hp, color)
        {
            Model = model;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Brand: " + brand);
            //Console.WriteLine("Model: " + Model);
            Console.WriteLine("Horsepower : " + HP);
            Console.WriteLine("Color : " + Color);
        }

        public new void Repair()
        {
            Console.WriteLine($"{brand} {Model} is repaired successfully!!");
        }

        public override void ShowRepair()
        {
            Console.WriteLine($"{brand} {Model} is repaired successfully!!");
        }
    }
}
