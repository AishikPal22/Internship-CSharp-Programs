namespace DeltaNetworks;
public class PlanDetails : Plan
{
    public PlanDetails()
    {
        
    }
    public bool ValidatePlanType()
    {
        if(String.Equals(PlanType, "Monthly") || String.Equals(PlanType, "Quarterly") || String.Equals(PlanType, "Annually"))
            return true;
        else
            return false;
    }
    public Plan CalculatePlanAmount()
    {
        if(String.Equals(PlanType, "Monthly"))
            PlanAmount = 405;
        else if(String.Equals(PlanType, "Quarterly"))
            PlanAmount = 1120;
        else if(String.Equals(PlanType, "Annually"))
            PlanAmount = 1200;
        return this;
    }
}