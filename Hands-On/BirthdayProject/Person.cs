using System;
using System.IO;

namespace BirthdayProject
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private DateTime dob;
        
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public DateTime DOB 
        { 
            get
            {
                return dob;
            }
            set
            {
                dob  = value;
            }
        }

        public Person(string fName, string lName, DateTime bdate)
        {
            FirstName = fName;
            LastName = lName;
            DOB = bdate;
            //Console.WriteLine(DOB);
        }

        public string Adult 
        { 
            get
            {
                if (GetAge(DOB) >= 18)
                    return "Adult";
                else
                    return "Child";
            }
        }

        public int GetAge(DateTime dates)
        {
            var dateNow = new DateTime(2021, 7, 16);
            var diff = dateNow - dates;
            return (int)(diff.Days / 365);
        }


        public void DisplayDetails()
        {
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Age: {GetAge(DOB)}");
            Console.WriteLine(Adult);
        }
    }
}
