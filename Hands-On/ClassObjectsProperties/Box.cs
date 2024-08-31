namespace ClassObjectsProperties
{
    public class Box
    {
        private int length = 0;
        private int width = 0;
        //private int height = 0;
        

        public Box()
        {
            Console.WriteLine("Object Created!!");
        }

        public Box(int length, int width, int  height)
        {
            this.length = length;
            Width = width;
            Height = height;
        }

        public Box(int edge)
        {
            Edge = edge;
        }

        public int Edge { get; set; }

        public int Width 
        {   get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public int Height { get; set; }

        public void printVolume()
        {
            Console.WriteLine("Volume is {0}.", this.length * Width * Height);
        }

        public double printEdgeVolume()
        {
            return Math.Pow(Edge, 3);
        }
    }
}
