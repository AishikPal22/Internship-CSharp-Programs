namespace QualifierQ1
{
    public class Program
    {
        public static List<Student> StudentList { get; set; } = new List<Student>();

        public static void Main(string[] args)
        {
            bool output = true;
            Student student = new Student();

            while (output)
            {
                Console.WriteLine("Choose the option");
                Console.WriteLine("1. Add Student Details\n2. Get student name by phone\n3. Remove student details\n4. Exit");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the student name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter date of birth");
                        string date = Console.ReadLine();
                        Console.WriteLine("Enter the phone number");
                        long phone = long.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the city");
                        string city = Console.ReadLine();
                        _ = student.AddStudentDetails(name, date, phone, city);

                        foreach (var item in StudentList)
                        {
                            Console.WriteLine($"{item.StudentName} {item.DOB} {item.PhoneNo} {item.City}");
                        }
                        output = true;
                        break;

                    case 2:
                        Console.WriteLine("Enter the phone number");
                        long num1 = long.Parse(Console.ReadLine());
                        Console.WriteLine(student.GetStudentName(num1));
                        output = true;
                        break;

                    case 3:
                        Console.WriteLine("Enter the phone number");
                        long num2 = long.Parse(Console.ReadLine());
                        int size1 = StudentList.Count;
                        _ = student.RemoveStudentDetails(num2);
                        int size2 = StudentList.Count;
                        if(size1 != size2)
                        {
                            foreach (var item in StudentList)
                            {
                                Console.WriteLine($"{item.StudentName} {item.DOB} {item.PhoneNo} {item.City}");
                            }
                        }
                        else
                            Console.WriteLine("Wrong input.");
                        output = true;
                        break;

                    case 4:
                        Console.WriteLine("Thank you.");
                        output = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option selected.");
                        output = true;
                        break;
                }
            }
        }
    }
}