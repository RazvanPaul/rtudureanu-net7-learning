/*public class BankAccount
{
    private int accountNumber;
    private string accountHolder;
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
    private double Balance { get; set; }
    private List <string> Transactions = new List<string> ();
    public BankAccount(int acccountNumber, string accountHolder, double Balance)
    {
        this.accountNumber = AccountNumber;
        this.accountHolder = AccountHolder;
        this.Balance = Balance;
    }
    public void Deposit(int amount)
    {
        Balance += amount;
        string depositMessage = $"Deposited: $ {amount}";
        Transactions.Add(depositMessage);
        
    }
    public void Withdraw(int amount)
    {
        Balance -= amount;
        string withdrawMessage = $"Withdrawn: $ {amount}";
        Transactions.Add(withdrawMessage);
        
    }
    public double GetBalance()
    {
        return Balance;
    }
    public List<string> GetTransactionsHistory()
    {
        return Transactions;
    }
}*/
