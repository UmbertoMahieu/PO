public class Saving
{
        public string Number;

        public double Balance {get; private set;}

        public DateTime DateLastWithdraw;

        public Person Owner; 


    public void Withdrawal(double amount)
    {
        this.Balance -= amount;
    }

    public void Deposit(double amount)
    {
        this.Balance += amount;
    }

}