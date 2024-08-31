using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashDemo
{
    public class Student
    {
        // Properties

        public int ID { get; set; }

        public string Name { get; set; }

        public float GPA { get; set; }

        // Constructor

        public Student()
        {
            // default constructor
        }
        
        public Student(int id, string name, float gpa)
        {
            ID = id;
            Name = name;
            GPA = gpa;
        }
    }
    
}
