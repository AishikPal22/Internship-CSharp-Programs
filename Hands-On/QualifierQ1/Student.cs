namespace QualifierQ1
{
    public class Student
    {
        public string StudentName { get; set; }
        public string DOB { get; set; }
        public long PhoneNo { get; set; }
        public string City { get; set; }

        public Student()
        {

        }

        public Student(string name, string dob, long phone, string city)
        {
            this.StudentName = name;
            this.DOB = dob;
            this.PhoneNo = phone;
            this.City = city;
        }

        //Program pr = new Program();

        public List<Student> AddStudentDetails(string name, string dob, long phone, string city)
        {
            Student student = new Student(name, dob, phone, city);
            Program.StudentList.Add(student);
            return Program.StudentList;
        }

        public string GetStudentName(long phone)
        {
            string result = "";
            foreach (var item in Program.StudentList)
            {
                if (item.PhoneNo == phone)
                    result += item.StudentName;
            }
            if (result.Length > 0)
                return result;
            else
                return "Wrong input.";
        }

        public List<Student> RemoveStudentDetails(long phone)
        {
            for(int i=0;i<Program.StudentList.Count;i++)
            {
                if (Program.StudentList[i].PhoneNo == phone)
                {
                    Program.StudentList.RemoveAt(i);
                }
            }
            return Program.StudentList;
        }
    }
}