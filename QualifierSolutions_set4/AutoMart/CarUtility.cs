namespace AutoMart
{
    public class CarUtility : Car
    {
        public bool ValidateCarModel()
        {
            if(Model=="A3"||Model=="A8"||Model=="Q5")
                return true;
            else
                return false;
        }
	  
	    public Car PriceCalculation()
        {
            if(BodyStyle=="Sedan")
            {
                Price=Price-0.05*Price;
            }
            else if(BodyStyle=="SUV")
            {
                Price=Price-0.1*Price;
            }
            else
            {
                Price=Price-0;
            }
            return this;
        }
    }
}