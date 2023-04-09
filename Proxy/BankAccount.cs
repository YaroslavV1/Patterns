using Proxy.Interfaces;

namespace Proxy;

public class BankAccount : IBankAccount
{
    private decimal _initialBalance;

    public BankAccount(decimal initialBalance)
    {
        _initialBalance = initialBalance;
    }
    
    public void Deposit(decimal amount)
    {
        _initialBalance += amount;
    }

    public void Withdraw(decimal amount)
    {
        _initialBalance -= amount;
    }

    public decimal GetBalance()
    {
        return _initialBalance;
    }
}