namespace InsuranceDetails
{
    public class MotorInsurance : Insurance
    {
        // members
        private double idv;
        private float depPercent;

        // properties
        public double Idv
        {
            get { return idv; } 
            set {  idv = value; }
        }
        public float DepPercent
        {
            get { return depPercent; }
            set { depPercent = value; }
        }

        // constructors
        public MotorInsurance() { }
        public MotorInsurance(string insuranceNo, string insuranceName, double amountCovered, float depPercent) : base (insuranceNo, insuranceName, amountCovered)
        {
            InsuranceNo = insuranceNo;
            InsuranceName = insuranceName;
            AmountCovered = amountCovered;
            DepPercent = depPercent;
        }

        // methods
        public override double calculatePremium()
        {
            Idv = AmountCovered - (AmountCovered * DepPercent / 100);
            return 0.03 * Idv;
        }
    }
}