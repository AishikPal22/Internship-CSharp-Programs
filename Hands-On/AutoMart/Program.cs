namespace AutoMart;
public class Program
{
    public static void Main(string[] args)
    {
        CarUtility c=new CarUtility();
        Console.WriteLine("Enter the model");
        c.Model = Console.ReadLine();
        if(c.ValidateCarModel())
        {
            Console.WriteLine("Enter the body style");
            c.BodyStyle=Console.ReadLine();
            Console.WriteLine("Enter the price");
            c.Price=Convert.ToDouble(Console.ReadLine());
            
            c = (CarUtility)c.PriceCalculation();
            
            Console.WriteLine("Model:"+c.Model);
            Console.WriteLine("Body Style:"+c.BodyStyle);
            Console.WriteLine("Price After Discount:"+c.Price);
        }
        else
        {
            Console.WriteLine("Invalid car model");
        }
    }
}
