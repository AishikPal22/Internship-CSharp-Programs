using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    public class Audi : Car
    {
        private string brand = "Audi";

        public string Model { get; set; }
        
        public Audi(int hp, string color, string model) : base(hp, color)
        {
            Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("Brand: " + brand);
            //Console.WriteLine("Model: " + Model);
            Console.WriteLine("Horsepower : " + HP);
            Console.WriteLine("Color : " + Color);
        }

        public void Repair()
        {
            Console.WriteLine($"{brand} {Model} is repaired successfully!!");
        }

        public override void ShowRepair()
        {
            Console.WriteLine($"{brand} {Model} is repaired successfully!!");
        }
    }
}
