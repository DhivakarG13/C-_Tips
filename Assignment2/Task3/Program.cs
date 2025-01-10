List<BankAccount> CustomerList = new List<BankAccount>
{
    new SavingsAccount()
    {
        AccountNumber = "Ab1234",
        Balance = 10000
    },
    new CheckingAccount()
    {
        AccountNumber = "Cd1234",
        Balance = 40000
    }
};

BankAccount Customer1 = new SavingsAccount()
{
    AccountNumber = "Mg1234",
    Balance = 10000
};
BankAccount Customer2 = new CheckingAccount()
{
    AccountNumber = "Qr1234",
    Balance = 100000
};

Customer1.PrintDetails();
Customer1.Deposit(5000);
Customer2.WithDrawl(100000);
Console.ReadKey();
public abstract class BankAccount
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public void Deposit(decimal Amount)
    {
        Balance += Amount;
    }
    public void PrintDetails()
    {
        Console.WriteLine($"The Accountnumber : {AccountNumber} \n Has an amount of : {Balance}");
    }
    public abstract void WithDrawl(decimal Amount);
} 
public class SavingsAccount: BankAccount
{
    public static int MinimumBalance = 500;

    public override void WithDrawl(decimal Amount)
    {
        if (Balance - Amount > MinimumBalance)
        {
            Console.WriteLine($"An amount of {Amount} is debited from your {this.GetType().Name}");
        }
        else
        {
            Console.WriteLine("Entered Amount is Exceeding the Limit");
            Console.WriteLine($"Available Balance : {Balance}");
            Console.WriteLine($"Withdrawable Amount : {Balance - MinimumBalance}");
        }
    }
}
public class CheckingAccount: BankAccount
{
    public override void WithDrawl(decimal Amount)
    {
        if(Amount <= Balance )
        {
            Console.WriteLine($"An amount of {Amount} is debited from your {this.GetType().Name}");
        }
        else
        {
            Console.WriteLine("Entered Amount is Exceeding the Limit");
            Console.WriteLine($"Available Balance : {Balance}");
            Console.WriteLine($"Withdrawable Amount : {Balance}");
        }
    }
}