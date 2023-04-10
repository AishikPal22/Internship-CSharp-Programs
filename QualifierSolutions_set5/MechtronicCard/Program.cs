namespace MechtronicCard
{
	public class Program
	{
		public static void Main(string[] args)
		{
		    Service service = new Service();
		    Console.WriteLine("Enter the customer name");
		    service.CustomerName = Console.ReadLine();
		    Console.WriteLine("Enter the card type");
		    service.CardType = Console.ReadLine();
		    Console.WriteLine("Enter the purchased amount");
		    service.PurchaseAmount = double.Parse(Console.ReadLine());
		    if(service.ValidateCardType())
		    	Console.WriteLine("Total Amount is " + service.CalculateTotalAmount());
		    else
		    	Console.WriteLine("Invalid card type");
		}
	}
	
	public class Bill
	{
		public string CustomerName {get;set;}
		public string CardType {get;set;}
		public double PurchaseAmount {get;set;}
	}
	
	public class Service : Bill
	{
		public bool ValidateCardType()
		{
			if((CardType=="Classic")||(CardType=="Gold")||(CardType=="Platinum")||(CardType=="Signature"))
				return true;
			else
				return false;
		}
		public double CalculateTotalAmount()
		{
			if(CardType=="Classic")
				return 0.95*PurchaseAmount;
			else if(CardType=="Gold")
				return 0.90*PurchaseAmount;
			else if(CardType=="Platinum")
				return 0.85*PurchaseAmount;
			else if(CardType=="Signature")
				return 0.80*PurchaseAmount;
			else
				return 0;
		}
	}
}
