// Account.cs
using System;

public class Account
{
    public string AccountNumber { get; private set; }
    public string Owner { get; private set; }
    public decimal Balance { get; private set; }

    public Account(string accountNumber, string owner, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Owner = owner;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount:C}. New balance: {Balance:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds!");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount:C}. New balance: {Balance:C}");
        }
    }

    public void PrintAccountDetails()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Owner: {Owner}");
        Console.WriteLine($"Balance: {Balance:C}");
    }
}
