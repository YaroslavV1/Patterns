namespace Proxy.Interfaces;

public interface IBankAccount
{
    public void Deposit(decimal amount);
    public void Withdraw(decimal amount);
    public decimal GetBalance();
}