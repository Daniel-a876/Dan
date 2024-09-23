class BankAccount
{
    private double balance;

    public void Deposit(double amount)
    {
        balance += amount;
    }
    public double getbalance()
    {
        return balance;
    }
}