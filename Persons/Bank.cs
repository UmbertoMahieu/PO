public class Bank
{
    public Dictionary<string, CurrentAccount> Accounts {get; private set;}

    public string Name;

    public Bank(string name)
    {
        this.Name = name;
        Accounts = new Dictionary<string, CurrentAccount>();
    }

    public void AddAccount(CurrentAccount account)
    {
        this.Accounts.Add(account.Number, account);
    }

    public void DeleteAccount(CurrentAccount account)
    {
        this.Accounts.Remove(account.Number);
    }

}