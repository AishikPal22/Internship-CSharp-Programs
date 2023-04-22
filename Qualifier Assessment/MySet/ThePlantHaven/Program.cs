namespace ThePlantHaven;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the plant details");
        string details = Console.ReadLine();

        PlantUtility p = new PlantUtility();

        _ = p.ExtractDetails(details);
        Console.WriteLine($"Plant name is : {p.PlantName}\nNo of sapling is : {p.NoOfSapling}\nCategory : {p.Category}\nPrice per sapling : {p.PricePerSapling}");
        Console.WriteLine("Total cost is : " + p.CalculateCost());
    }
}
