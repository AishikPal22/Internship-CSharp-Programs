namespace HealthCare;
public class Program
{
    public static List<Vaccine> VaccineList = new List<Vaccine>();
    
    public static void Main(string[] args)
    {
        Program pr = new Program();
        while(true)
        {
            Console.WriteLine("\n1.Add Vaccine Details\n2.View Details By Dose number\n3.View Details By Vaccine Type\n4.Exit\nEnter the choice");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter the number of entries");
                    //int entries = int.Parse(Console.ReadLine());
                    int entries = 3;
                    string[] VaccineDetails = new string[entries];
                    VaccineDetails[0] = "M001,Raj,COVIDSHIELD,DOSE 1,25/12/2022";
                    VaccineDetails[1] = "M002,Alex,COVAXIN,DOSE 1,25/12/2022";
                    VaccineDetails[2] = "M003,Mohammed,COVIDSHIELD,DOSE 2,25/12/2022";
                    // for(int i=0; i<entries; i++)
                    // {
                    //     VaccineDetails[i] = Console.ReadLine();
                    // }
                    pr.AddVaccineDetails(VaccineDetails);
                    break;

                case 2:
                    Console.WriteLine("Enter the dose number");
                    string number = Console.ReadLine();
                    List<Vaccine> myList1 = pr.ViewBookingDetailsByDosenumber(number);
                    if(myList1.Count > 0)
                    {
                        foreach(Vaccine item in myList1)
                        {
                            Console.WriteLine($"{item.BookingId} {item.Name} {item.VaccineType} {item.DoseNumber} {item.BookingDate}");
                        }
                    }
                    else
                        Console.WriteLine("Dose number not found");
                    break;

                case 3:
                    Console.WriteLine("Enter the vaccine type");
                    string type = Console.ReadLine();
                    List<Vaccine> myList2 = pr.ViewBookingDetailsByVaccineType(type);
                    if(myList2.Count > 0)
                    {
                        foreach(Vaccine item in myList2)
                        {
                            Console.WriteLine($"{item.BookingId} {item.Name} {item.VaccineType} {item.DoseNumber} {item.BookingDate}");
                        }
                    }
                    else
                        Console.WriteLine("Vaccine type not found");
                    break;

                case 4:
                    Console.WriteLine("Thank you");
                    return;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }

    public void AddVaccineDetails(string[] vaccineDetails)
    {
        foreach(string item in vaccineDetails)
        {
            string[] details = item.Split(",");
            Vaccine vaccine = new Vaccine(details[0], details[1], details[2], details[3], details[4]);
            VaccineList.Add(vaccine);
        }
    }

    public List<Vaccine> ViewBookingDetailsByDosenumber(string dosenumber)
    {
        List<Vaccine> myList = new List<Vaccine>();
        foreach(Vaccine item in VaccineList)
        {
            if(String.Equals(item.DoseNumber, dosenumber))
            {
                myList.Add(item);
            }
        }
        return myList;
    }

    public List<Vaccine> ViewBookingDetailsByVaccineType(string vaccineType)
    {
        List<Vaccine> myList = new List<Vaccine>();
        foreach(Vaccine item in VaccineList)
        {
            if(String.Equals(item.VaccineType, vaccineType))
            {
                myList.Add(item);
            }
        }
        return myList;
    }
}
