namespace Phoenix
{
    public class Player
    {
        public string Number {get;set;}
        public string Name {get;set;}
        public int Age {get;set;}
        public string InterestedIn {get;set;}

        public Player() {}
        
        public Player(string v1, string v2, int v3, string v4)
        {
            Number = v1;
            Name = v2;
            Age = v3;
            InterestedIn = v4;
        }
    }
}