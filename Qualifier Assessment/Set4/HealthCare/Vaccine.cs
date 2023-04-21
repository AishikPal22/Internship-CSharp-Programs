namespace HealthCare
{
    public class Vaccine
    {
        public string BookingId {get;set;}
        public string Name {get;set;}
        public string VaccineType {get;set;}
        public string DoseNumber {get;set;}
        public string BookingDate {get;set;}

        public Vaccine() {}
        
        public Vaccine(string v1, string v2, string v3, string v4, string v5)
        {
            BookingId = v1;
            Name = v2;
            VaccineType = v3;
            DoseNumber = v4;
            BookingDate = v5;
        }
    }
}