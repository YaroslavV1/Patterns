using Proxy.Interfaces;

namespace Proxy;

public class BankAccount : IBankAccount
{
    private decimal _balance;

    public BankAccount(decimal balance)
    {
        _balance = balance;
    }
    
    public void Deposit(decimal amount)
    {
        _balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        _balance -= amount;
    }

    public decimal GetBalance()
    {
        return _balance;
    }
}