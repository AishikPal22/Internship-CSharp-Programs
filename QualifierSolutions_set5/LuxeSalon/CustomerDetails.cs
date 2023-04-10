namespace LuxeSalon
{
    public class CustomerDetails : Customer
    {
        public bool ValidateMemberType()
        {
            if((MemberType == "Gold")||(MemberType == "Diamond")||(MemberType == "Platinum"))
                return true;
            else
                return false;
        }

        public double ServiceChargeAfterDiscount()
        {
            if(MemberType == "Gold")
                return 0.95*ServiceCharge;
            else if(MemberType == "Diamond")
                return 0.9*ServiceCharge;
            else if(MemberType == "Platinum")
                return 0.85*ServiceCharge;
            else
                return 0;
        }       
    }
}