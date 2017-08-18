namespace SexShop
{
    class User
    {
        public string Name { get; private set; }
        public string Adress { get; private set; }
        public double Balance { get; private set; }
        public double Spent { get; private set; }

        public User(string name, string adress, int balance, int spent)
        {
            Name = name;
            Adress = adress;
            Balance = balance;
            Spent = spent;
        }

        public void ReduceBalance(double price)
        {
            Balance -= price; 
            Spent += price; 
        }
    }
}
