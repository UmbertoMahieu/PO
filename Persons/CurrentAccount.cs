public class CurrentAccount
{
    public string Number;

    public double Balance {get ; private set;}

    public double CreditLine;

    public Person Owner;

    public CurrentAccount(string number, Person owner)
    {
        this.Number = number;
        this.Balance = 0;
        this.CreditLine = -500;
        this.Owner = owner;
    }

    public void Withdrawal(double amount)
    {
        this.Balance -= amount;
    }

    public void Deposit(double amount)
    {
        this.Balance += amount;
    }

}