using Proxy.Interfaces;

namespace Proxy;

public class BankAccountProxy : IBankAccount
{
    private readonly BankAccount _bankAccount;
    private readonly bool _isAuthenticated;

    public BankAccountProxy(decimal initialBalance, bool isAuthenticated)
    {
        _bankAccount = new BankAccount(initialBalance);
        _isAuthenticated = isAuthenticated;
    }
    
    public void Deposit(decimal amount)
    {
        ThrowIfAccessDenied(_isAuthenticated);
        _bankAccount.Deposit(amount);
    }

    public void Withdraw(decimal amount)
    {
        ThrowIfAccessDenied(_isAuthenticated);
        
        var currentBalance = _bankAccount.GetBalance() - amount;
        ThrowIfBalanceIsMinus(currentBalance);
        
        _bankAccount.Withdraw(amount);
    }

    public decimal GetBalance()
    {
        ThrowIfAccessDenied(_isAuthenticated);
        
        return _bankAccount.GetBalance();
    }

    private void ThrowIfAccessDenied(bool isAuthenticated)
    {
        if (!isAuthenticated)
        {
            throw new Exception("Access denied!");
        }
    }

    private void ThrowIfBalanceIsMinus(decimal amount)
    {
        if (amount < decimal.Zero)
        {
            throw new Exception("Balance is less than 0!");
        }
    }
}