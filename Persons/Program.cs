
Bank bank1 = new Bank("Belfius");
Person clt1 = new Person("Louis", "Despiegleare", new DateTime(2000,12,29));
CurrentAccount acc1 = new CurrentAccount("1", clt1);
bank1.AddAccount(acc1);

Console.WriteLine(acc1.Owner.Name + " " + acc1.Balance);

acc1.Deposit(500);

Console.WriteLine(acc1.Owner.Name + " " + acc1.Balance);