namespace IncrementableInterface
{
    public class Manager : Employee, IIncrementable
    {
        protected string teamId;

        public Manager(string teamId)
        {
            this.teamId = teamId;
        }
        public Manager(string name, double salary, string teamId)
        {
            this.name = name;
            this.salary = salary;
            this.teamId = teamId;
        }

        public double Increment()
        {
            return this.salary += (0.5 * this.salary);
        }
        public override void Print()
        {
            double result = Increment();
            System.Console.WriteLine($"Name: {this.name}\nSalary: {result}");
        }
    }
}