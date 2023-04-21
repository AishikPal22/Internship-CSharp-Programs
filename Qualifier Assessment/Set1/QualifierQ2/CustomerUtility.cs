namespace QualifierQ2
{
    public class CustomerUtility : Customer
    {
        public CustomerUtility(string name, long ssn, string city, double loan, int years)
        {
            CustomerName = name;
            SSN = ssn;
            City = city;
            LoanAmount = loan;
            NoOfYears = years;
        }

        public string GenerateTokenNumber()
        {
            return String.Concat(CustomerName.Substring(0, 2).ToUpper(), City.Substring(2, 1).ToUpper(), SSN % 100);
        }
        public double CalculateAnnualInterest(string loanType)
        {
            double interest = 0;
            if(String.Equals(loanType, "Home"))
            {
                interest = LoanAmount * 0.03 * NoOfYears;
            }
            else if(String.Equals(loanType, "Business"))
            {
                interest = LoanAmount * 0.05 * NoOfYears;
            }
            else if(String.Equals(loanType, "Gold"))
            {
                interest = LoanAmount * 0.02 * NoOfYears;
            }
            return interest;
        }
    }
}
