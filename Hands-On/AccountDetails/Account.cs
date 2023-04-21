namespace AccountDetails
{
    public class Account
    {
        // class members
        private int id;
        private string accountType;
        double balance;

        // class properties
        public int ID 
        { 
            get
            {
                return id;
            } 
            set
            {
                id = value;
            } 
        }
        public string AccountType 
        { get 
            {  
                return accountType; 
            } 
            set 
            { 
                accountType = value; 
            } 
        }
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        // class constructors
        public Account()
        {

        }
        public Account(int id, string accountType, double balance)
        {
            ID = id;
            AccountType = accountType;
            Balance = balance;
        }

        // class methods
        //double newBalance = 0;
        public bool WithDraw(double amount)
        {
            if (Balance > amount)
            {
                Balance = Balance - amount;
                return true;
            }
            else
                return false;
        }
        public string GetDetails()
        {
            string result = "Account Id: " + ID + "\nAccount Type: " + AccountType + "\nBalance: " + Balance;
            return result;
        }
    }
}
