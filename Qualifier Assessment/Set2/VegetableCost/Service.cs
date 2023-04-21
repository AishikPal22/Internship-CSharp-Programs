namespace VegetableCost;
public class Service : Vegetable
{
    public Service()
    {

    }

    public bool ValidateBillId()
    {
        if(BillId.Length == 7)
        {
            bool digit_check = false; 
            for(int i = 0 ; i < 3 ; i++)
            {
                if(char.IsDigit(BillId.ElementAt(i)))
                    digit_check = true;
                else
                    digit_check = false;
            }
            bool char_check = false;
            for(int i = 4 ; i < 7 ; i++)
            {
                if(char.IsLetter(BillId.ElementAt(i)) && char.IsUpper(BillId.ElementAt(i)))
                    char_check = true;
                else
                    char_check = false;

            }
            if(digit_check && char_check && BillId.ElementAt(3)=='-')
                return true;
            else
                return false;
        }
        else
            return false; 
    }
    public double CalculateTotalCost(float quantity)
    {
        return CostPerPack*(quantity*1000)/GramsInPack;
    }
}