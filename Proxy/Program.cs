using Proxy;
using Proxy.Interfaces;

User firstUser = new() { Name = "Georgy", Balance = 500, IsAuthenticated = true };
User secondUser = new() { Name = "Michel", Balance = 5000, IsAuthenticated = false };

Console.WriteLine("\n\t Starting program");
Console.WriteLine("\n Check first User");

IBankAccount bankAccount = new BankAccountProxy(firstUser.Balance, firstUser.IsAuthenticated);

Console.WriteLine("\n Check the deposit possibility:");
bankAccount.Deposit(50);
Console.WriteLine($"Balance: {bankAccount.GetBalance()}");

Console.WriteLine("\n Check the withdraw possibility:");
bankAccount.Withdraw(50);
Console.WriteLine($"Balance: {bankAccount.GetBalance()}");

CheckDepositPossibility(bankAccount);

Console.WriteLine("\n Check second User");

IBankAccount bankAccount2 = new BankAccountProxy(secondUser.Balance, secondUser.IsAuthenticated);

CheckDepositPossibility(bankAccount2);

void CheckDepositPossibility(IBankAccount bankAccount)
{
    try
    {
        Console.WriteLine("\n Check the deposit possibility:");
        bankAccount.Deposit(50);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }
    finally
    {
        Console.WriteLine($"Balance: {bankAccount.GetBalance()}");
    }
}