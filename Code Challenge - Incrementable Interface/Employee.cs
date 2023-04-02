namespace IncrementableInterface
{
    abstract public class Employee : IIncrementable
    {
        protected string name;
        protected double salary;

        public virtual void Print()
        {
            System.Console.WriteLine($"Name:{name}\nSalary:{salary}");
        }
    }
}