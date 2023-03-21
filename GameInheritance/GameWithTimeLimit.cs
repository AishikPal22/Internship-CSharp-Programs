namespace GameInheritance
{
    public class GameWithTimeLimit : Game
    {
        public int TimeLimit { get; set; }
        public GameWithTimeLimit(string name, int num, int time) : base(name, num)
        {
            Name = name;
            MaxNumPlayers = num;
            TimeLimit = time;
        }

        public override string ToString()
        {
            return $"Maximum number of players for {Name} is {MaxNumPlayers}\nTime Limit for {Name} is {TimeLimit} minutes";
        }
    }
}
