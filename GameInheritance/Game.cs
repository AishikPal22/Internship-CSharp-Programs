namespace GameInheritance
{
    public class Game
    {
        public string Name { get; set; }
        public int MaxNumPlayers { get; set; }

        public Game(string name, int num)
        {
            Name = name;
            MaxNumPlayers = num;
        }

        public override string ToString()
        {
            return $"Maximum number of players for {Name} is {MaxNumPlayers}";
        }
    }
}
