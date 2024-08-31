namespace ClassObjectsProperties
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter length, width and height of the box: ");
            int l = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            Box cuboid = new Box(l, w, h);
            cuboid.printVolume();
            Box cube = new Box(l);
            Console.WriteLine("Volume is {0}.",cube.printEdgeVolume());
        }
    }
}