using System;

namespace TravelCost
{
    public class Service : Travel
    {
        public Service(string travelId, string departurePlace, string destinationPlace, int noOfDays, double costPerDay)
        {
            TravelId = travelId;
            DeparturePlace = departurePlace;
            DestinationPlace = destinationPlace;
            NoOfDays = noOfDays;
            CostPerDay = costPerDay;
        }
        
        public bool ValidateTravelId(string travelId)
        {
            string check = String.Concat(DeparturePlace.Substring(0,3).ToUpper(), "/", DestinationPlace.Substring(0,3).ToUpper());
            if(String.Equals(check, travelId))
            {
                return true;
            }
            else
                return false;
        }
        public double CalculateDiscountedCost()
        {
            //return ((CostPerDay*NoOfDays)-((CostPerDay*NoOfDays)*DiscountPercentage));
            if(NoOfDays <= 5)
                return (CostPerDay*NoOfDays);

            else if(NoOfDays > 5 && NoOfDays <= 8)
                return ((CostPerDay*NoOfDays)-((CostPerDay*NoOfDays)*0.03));

            else if(NoOfDays > 8 && NoOfDays <= 10)
                return ((CostPerDay*NoOfDays)-((CostPerDay*NoOfDays)*0.05));

            else if(NoOfDays > 10)
                return ((CostPerDay*NoOfDays)-((CostPerDay*NoOfDays)*0.07));
            else
                return 0;
        }
    }
}