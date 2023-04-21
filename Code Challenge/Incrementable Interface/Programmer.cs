namespace IncrementableInterface
{
    public class Programmer : Employee, IIncrementable
    {
        protected string domain;

        public Programmer(string domain)
        {
            this.domain = domain;
        }
        public Programmer(string name, double salary, string domain)
        {
            this.name = name;
            this.salary = salary;
            this.domain = domain;
        }

        public double Increment()
        {
            return this.salary += (0.1 * this.salary);
        }
        public override void Print()
        {
            double result = Increment();
            System.Console.WriteLine($"Name: {this.name}\nSalary: {result}");
        }
    }
}