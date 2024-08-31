using System.Collections;

namespace HashDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // creating array of object students
            
            Console.WriteLine("Enter the number of student data to be entered: ");
            int size = int.Parse(Console.ReadLine());
            Student[] students = new Student[size];

            // assigning value to the objects

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Enter details of student{0} :-", i+1);
                Console.WriteLine("Enter id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter GPA: ");
                float gpa = float.Parse(Console.ReadLine());
                students[i] = new Student(id, name, gpa);
            }

            // adding data to hashtable

            Hashtable hashtable = new Hashtable();
            for (int i = 0; i < students.Length; i++)
            {
                hashtable.Add(students[i].ID, students[i]);
            }

            // printing data from hashtable

            for (int i = 0; i < students.Length; i++)
            {
                Student output = (Student)hashtable[students[i].ID];
                Console.WriteLine("Student{0} info by method1: \n{1} , {2} , {3}", i+1, output.ID, output.Name, output.GPA);
            }

            int j = 1;
            foreach(DictionaryEntry entry in hashtable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student{0} info by method2: \n{1} , {2} , {3}", j, temp.ID, temp.Name, temp.GPA);
                j += 1;
            }
        }
    }
}