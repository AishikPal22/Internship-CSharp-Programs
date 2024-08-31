namespace InsuranceDetails
{
    public class Insurance
    {
        // members
        private string insuranceNo;
        private string insuranceName;
        private double amountCovered;

        // properties
        public string InsuranceNo
        {
            get { return insuranceNo; }
            set { insuranceNo = value; }
        }
        public string InsuranceName
        {
            get { return insuranceName; }
            set { insuranceName = value; }
        }
        public double AmountCovered
        {
            get { return amountCovered; }
            set { amountCovered = value; }
        }

        // constructors
        public Insurance() { }
        public Insurance(string insuranceNo, string insuranceName, double amountCovered)
        {
            InsuranceNo = insuranceNo;
            InsuranceName = insuranceName;
            AmountCovered = amountCovered;
        }

        // methods
        public virtual double calculatePremium()
        {
            return 0;
        }
    }
}
