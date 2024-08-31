namespace InsuranceDetails
{
    public class LifeInsurance : Insurance
    {
        // members
        private int policyTerm;
        private float benefitPercent;

        // properties
        public int PolicyTerm
        {
            get { return policyTerm; }
            set { policyTerm = value; }
        }
        public float BenefitPercent
        {
            get { return benefitPercent; }
            set { benefitPercent = value; }
        }

        // constructors
        public LifeInsurance() { }
        public LifeInsurance(string insuranceNo, string insuranceName, double amountCovered, int policyTerm, float benefitPercent) : base (insuranceNo, insuranceName, amountCovered)
        {
            InsuranceNo = insuranceNo;
            InsuranceName = insuranceName;
            AmountCovered = amountCovered;
            PolicyTerm = policyTerm;
            BenefitPercent = benefitPercent;
        }

        // methods
        public override double calculatePremium()
        {
            return ((AmountCovered - ((AmountCovered * BenefitPercent) / 100)) / PolicyTerm);
        }
    }
}