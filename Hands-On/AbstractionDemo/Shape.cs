using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    abstract class Shape
    {
        public string Name { get; set; }

        public Shape()
        {
            
        }
        
        public virtual void GetInfo()
        {
            Console.WriteLine("This is a {0}.", Name);
        }

        public abstract double GetVolume();
    }
}
