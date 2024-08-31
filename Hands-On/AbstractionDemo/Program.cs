namespace AbstractionDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Shape shape = new Shape(); // will show error since Shape is abstract
            
            Shape cube1 = new Cube(4);
            cube1.GetInfo();
            Console.WriteLine("Volume : " + cube1.GetVolume());
            
            Console.WriteLine("\n");
            
            Cube cube2 = new Cube(7);
            cube2.GetInfo();
            Console.WriteLine("Volume : " + cube2.GetVolume());
        }
    }
}