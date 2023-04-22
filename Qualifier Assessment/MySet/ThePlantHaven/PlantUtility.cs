namespace ThePlantHaven
{
    public class PlantUtility : Plant
    {
        public Plant ExtractDetails(string plantDetails)
        {
            string[] info = plantDetails.Split(":");
            this.PlantName = info[0];
            this.NoOfSapling = int.Parse(info[1]);
            this.Category = info[2];
            this.PricePerSapling = int.Parse(info[3]);
            return this;
        }

        public double CalculateCost()
        {
            double amount = this.NoOfSapling * this.PricePerSapling;
            if(amount>500 && amount<=1000)
                return 0.9*amount;
            else if(amount>1000)
                return 0.8*amount;
            else
                return amount;
        }
    }
}