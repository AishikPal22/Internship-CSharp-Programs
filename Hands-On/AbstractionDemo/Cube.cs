using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    class Cube : Shape
    {
        public int Length { get; set; }

        public Cube(int l)
        {
            Name = "cube";
            Length = l;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Length : " + Length);
        }

        public override double GetVolume()
        {
            return Math.Pow(Length,3);
        }
    }
}
