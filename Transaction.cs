// Transaction.cs
using System;

public class Transaction
{
    public static void ExecuteTransaction(Account account, decimal amount, TransactionType type)
    {
        switch (type)
        {
            case TransactionType.Deposit:
                account.Deposit(amount);
                break;

            case TransactionType.Withdrawal:
                account.Withdraw(amount);
                break;

            default:
                Console.WriteLine("Invalid transaction type.");
                break;
        }
    }
}

public enum TransactionType
{
    Deposit,
    Withdrawal
}
