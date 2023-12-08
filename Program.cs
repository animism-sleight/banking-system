// Program.cs
using System;

class Program
{
    static void Main()
    {
        // Create an account
        var myAccount = new Account("123456789", "John Doe", 1000);

        // Perform transactions
        Transaction.ExecuteTransaction(myAccount, 500, TransactionType.Deposit);
        Transaction.ExecuteTransaction(myAccount, 200, TransactionType.Withdrawal);
        Transaction.ExecuteTransaction(myAccount, 1000, TransactionType.Withdrawal);

        // Print account details
        myAccount.PrintAccountDetails();
    }
}
