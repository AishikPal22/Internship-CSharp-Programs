namespace QualifierQ3
{
    public class Program
    {
        public static List<Appointment> AppointmentList { get; set; } = new List<Appointment>();
        
        public static void Main(string[] args)
        {
            Program pr = new Program();
            
            bool output = true;
            while(output)
            {
                Console.WriteLine("1. Add Appointment Details\n2. View Details by Appointment Reason\n3. View Details by Appointment Date\n4. Exit");
                Console.WriteLine("Enter the choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the number of entries");
                        int entries = int.Parse(Console.ReadLine());
                        string[] details = new string[entries];
                        for (int i = 0; i < entries; i++)
                        {
                            details[i] = Console.ReadLine();
                        }

                        //string[] details = new string[3];
                        //details[0] = "Alex,25/01/2023,07.00 PM,Fever";
                        //details[1] = "Robin,26/01/2023,04.00 PM,Fever";
                        //details[2] = "Mohammed,25/01/2023,08.00 PM,Stomach Pain";

                        pr.AddAppointmentDetails(details);
                        output = true;
                        break;

                    case 2:
                        Console.WriteLine("Enter the appointment reason");
                        string reason = Console.ReadLine();
                        List<Appointment> result_reason = pr.ViewBookingDetailsByReason(reason);
                        if (result_reason.Count != 0)
                        {
                            foreach (var item in result_reason)
                            {
                                Console.WriteLine($"{item.PatientName}\t{item.Date}\t{item.Time}\t{item.Reason}");
                            }
                        }
                        else
                            Console.WriteLine("Reason not found");
                        output = true;
                        break;

                    case 3:
                        Console.WriteLine("Enter the appointment date");
                        string date = Console.ReadLine();
                        List<Appointment> result_date = pr.ViewBookingDetailsByDate(date);
                        if(result_date.Count != 0)
                        {
                            foreach (var item in result_date)
                            {
                                Console.WriteLine($"{item.PatientName}\t{item.Date}\t{item.Time}\t{item.Reason}");
                            }
                        }
                        else
                            Console.WriteLine("Date not found");
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
            //Console.WriteLine("Thank you.");
        }

        public void AddAppointmentDetails(string[] details)
        {
            foreach(string item in details)
            {
                string[] info = item.Split(',');
                Appointment app = new Appointment();
                app.PatientName = info[0];
                app.Date = info[1];
                app.Time = info[2];
                app.Reason = info[3];
                AppointmentList.Add(app);               
            }
            //Console.WriteLine("Details added!");
        }

        public List<Appointment> ViewBookingDetailsByReason(string reason)
        {
            List<Appointment> result = new List<Appointment>();
            //Console.WriteLine("List for reason: {0}", result.Count);
            foreach (var item in AppointmentList)
            {
                if(item.Reason == reason)
                {
                    result.Add(item); 
                }
            }
            return result;
        }

        public List<Appointment> ViewBookingDetailsByDate(string date)
        {
            List<Appointment> result = new List<Appointment>();
            //Console.WriteLine("List for date: {0}", result.Count);
            foreach (var item in AppointmentList)
            {
                if (item.Date == date)
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
