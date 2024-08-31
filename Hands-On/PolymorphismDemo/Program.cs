namespace PolymorphismDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>(); // creating list of objects of parent class
            
            Car audi_car = new Audi(200, "blue", "A6");
            Car bmw_car = new BMW(250, "silver", "X1");

            //putting objects of child classes into a list assigned for objects of parent class
            cars.Add(audi_car);
            cars.Add(bmw_car);

            Audi audi = new Audi(330, "black", "A3"); // creating an object of child class
            BMW bmw = new BMW(300, "white", "X7"); // creating an object of child class

            // iterating through the list
            foreach (Car item in cars)
            {
                item.ShowDetails(); // calls method from parent class since object is of parent class
            }

            Console.WriteLine("\n");

            // calls method from child class since object is of child class
            // 'new' keyword ensures that method from child class hides that of parent class
            audi.ShowDetails();
            bmw.ShowDetails();

            Console.WriteLine("\n");

            // iterating through the list 
            foreach (Car item in cars)
            {
                item.Repair(); // calls method from parent class
            }

            Console.WriteLine("\n");

            foreach (Car item in cars)
            {
                item.ShowRepair(); // overrides method from parent class with that of child class
            }

            Console.WriteLine("\n");

            audi.Repair();
            bmw.Repair();
        }
    }
}