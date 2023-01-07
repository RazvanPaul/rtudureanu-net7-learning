public static class Bank
{
    static double InterestRate = 0.01;
    static int NumAccounts = 0;
    public static double CalculateInterest()
    {
        double interest;
        double balance=0;
        interest = balance * InterestRate;
        return interest;
    }
    public static int GetNumAccounts()
    {
        return NumAccounts;
    }

}
public class BankAccount
{
    private int accountNumber;
    private string accountHolder;
    private double balance;
    public int AccountNumber
    {
        get { return this.accountNumber; }
        set { this.accountNumber = value; }
    }
    public string AccountHolder
    {
        get { return this.accountHolder; }
        set { this.accountHolder = value; }
    }
    public double Balance
    {
        get { return this.balance; }
        set { this.balance = value; }
    }
    public BankAccount(int accountNumber, string accountHolder, double balance)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = balance;
        
    }
    public void Deposit(int amount)
    {
        Balance += amount;
    }
    public void Withdraw(int amount)
    {
        Balance -= amount;
    }
    public double GetInterest()
    {
        double InterestRate = 0.01;
        double interest;

        interest = balance * InterestRate;
        return interest;

    }
    
}

