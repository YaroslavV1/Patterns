using Proxy.Interfaces;

namespace Proxy;

public class BankAccountProxy : IBankAccount
{
    private readonly BankAccount _realBankAccount;
    private readonly bool _isAuthenticated;

    public BankAccountProxy(decimal initialBalance, bool isAuthenticated)
    {
        _realBankAccount = new BankAccount(initialBalance);
        _isAuthenticated = isAuthenticated;
    }
    
    public void Deposit(decimal amount)
    {
        ThrowIfAccessDenied(_isAuthenticated);
        _realBankAccount.Deposit(amount);
    }

    public void Withdraw(decimal amount)
    {
        ThrowIfAccessDenied(_isAuthenticated);
        var currentBalance = _realBankAccount.GetBalance() - amount;
        ThrowIfBalanceIsMinus(currentBalance);
        _realBankAccount.Withdraw(amount);
    }

    public decimal GetBalance()
    {
        ThrowIfAccessDenied(_isAuthenticated);
        return _realBankAccount.GetBalance();
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
        if (amount < 0)
        {
            throw new Exception("Balance is less than 0!");
        }
    }
}