namespace MotorsHut
{
    public class Service : Parking
    {
        public void ExtractDetails(string parkingDetails)
        {
            string[] details = parkingDetails.Split(":");
            VehicleNumber = details[0];
            VehicleType =details[1];
            NumberOfDays = int.Parse(details[2]);
        }
        public bool ValidateVehicleType()
        {
            if((String.Equals(VehicleType, "2 Wheeler"))||(String.Equals(VehicleType, "3 Wheeler"))||(String.Equals(VehicleType, "4 Wheeler")))
                return true;
            else
                return false;
        }
        public double CalculateTotalAmount()
        {
            if(String.Equals(VehicleType, "2 Wheeler"))
            {
                return 50*NumberOfDays;
            }
            else if(String.Equals(VehicleType, "3 Wheeler"))
            {
                return 70*NumberOfDays;
            }
            else 
            {
                return 100*NumberOfDays;
            }
        }
    }
}