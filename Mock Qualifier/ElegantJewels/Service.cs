using System;

namespace ElegantJewels
{
    public class Service : Bill
    {
        public void ExtractDetails(string billDetails)
        {
            string[] details = billDetails.Split(":");
            //Bill bill = new Bill();
            MetalName = details[0];
            Weight = double.Parse(details[1]);
            PurityOfMetal = double.Parse(details[2]);
            WantDecoration = bool.Parse(details[3]);
        }
        public bool ValidateMetalName()
        {
            if((String.Equals(MetalName, "Gold"))||(String.Equals(MetalName, "Silver")))
            {
                return true;
            }
            else
                return false;
        }
        public double CalculateTotalPrice()
        {
            double total = 0;
            if(String.Equals(MetalName, "Gold"))
            {
                total = 5000*(PurityOfMetal/100)*Weight;
            }
            else if(String.Equals(MetalName, "Silver"))
            {
                total = 100*(PurityOfMetal/100)*Weight;
            }
            if(WantDecoration)
                total+=(0.1*total);

            return total;
        }
    }
}