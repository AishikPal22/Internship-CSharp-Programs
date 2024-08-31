using System.Globalization;

namespace VSTLiteCourier
{
    public class CourierDetails : Courier
    {
        public CourierDetails()
        {

        }
        
        public void FindServiceType()
        {
            if(PickUpDate.CompareTo(DeliveryDate)==0)
            {
                ServiceType = "SameDay";
            }
            else if((DeliveryDate.Subtract(PickUpDate)).Days <= 3 && (DeliveryDate.Subtract(PickUpDate)).Days > 0)
            {
                ServiceType = "Express";
            }
            else if((DeliveryDate.Subtract(PickUpDate)).Days > 3)
            {
                ServiceType = "Standard";
            }
            else if((DeliveryDate.Subtract(PickUpDate)).Days < 0)
            {
                ServiceType = "Invalid";
            }
        }
        public double CalculateDeliveryCharge()
        {
            double extra = 0;
            if(String.Equals(ServiceType, "SameDay"))
                extra = 0.5 * Cost;
            if(String.Equals(ServiceType, "Express"))
                extra = 0.3 * Cost;
            
            return Cost + extra;
        }
    }
}