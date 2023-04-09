using Proxy;
using Proxy.Interfaces;

User user1 = new() { Name = "Georgy", Balance = 500, IsAuthenticated = true };
User user2 = new() { Name = "Michel", Balance = 5000, IsAuthenticated = false };

Console.WriteLine("\n\t Starting program");
Console.WriteLine("\n Check first User");

IBankAccount bankAccount = new BankAccountProxy(user1.Balance, user1.IsAuthenticated);

Console.WriteLine("\n Check the deposit possibility:");
bankAccount.Deposit(50);
Console.WriteLine($"Balance: {bankAccount.GetBalance()}");

Console.WriteLine("\n Check the withdraw possibility:");
bankAccount.Withdraw(50);
Console.WriteLine($"Balance: {bankAccount.GetBalance()}");

try
{
    Console.WriteLine("\n Check the possibility of withdrawing more than user have:");
    bankAccount.Withdraw(1000);
}
catch (Exception e)
{
    Console.WriteLine(e);
}
finally
{
    Console.WriteLine($"\n Balance: {bankAccount.GetBalance()}");
}

Console.WriteLine("\n Check second User");

IBankAccount bankAccount2 = new BankAccountProxy(user2.Balance, user2.IsAuthenticated);

try
{
    Console.WriteLine("\n Check the deposit possibility:");
    bankAccount2.Deposit(50);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}
finally
{
    Console.WriteLine($"Balance: {bankAccount2.GetBalance()}");
}




