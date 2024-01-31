using Bank.Business;
using Bank.Business.Imp;
using Bank.Model;
using System;

namespace Bank.App
{
    internal class Program
    {
        public static void ProcessChoice(string choice, IAccountService accountService)
        {
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter your account number (16 digits):");
                    var accountNumber = Console.ReadLine();
                    Console.WriteLine("Enter your name:");
                    var name = Console.ReadLine();
                    Console.WriteLine("Enter your phone number:");
                    var phoneNumber = Console.ReadLine();
                    Console.WriteLine("Enter your account type:");
                    var accountType = Console.ReadLine();
                    Console.WriteLine("Enter your initial balance (at least 500 BDT)");
                    var balance = Convert.ToDecimal(Console.ReadLine());
                    var account = new Account
                    {
                        AccountNo = accountNumber,
                        AccountName = name,
                        PhoneNo = phoneNumber,
                        AccountType = accountType,
                        Balance = balance
                    };

                    var result = accountService.CreateAccount(account);
                    if (result)
                    {
                        Console.WriteLine("Account created successfully");
                    }
                    else
                    {
                        Console.WriteLine("Account creation failed");
                    }
                    break;
                case "2":
                    var accounts = accountService.GetAllAccounts();
                    foreach (var single_account in accounts)
                    {
                        Console.WriteLine($"Account No: {single_account.AccountNo}");
                        Console.WriteLine($"Account Name: {single_account.AccountName}");
                        Console.WriteLine($"Account Type: {single_account.AccountType}");
                        Console.WriteLine($"Account Balance: {single_account.Balance}");
                        Console.WriteLine($"Account Creation Date: {single_account.CreationDate}");
                        Console.WriteLine($"Account Phone Number: {single_account.PhoneNo}");
                        Console.WriteLine("--------------------------------------------------");
                    }
                    break;
                case "3":
                    Console.WriteLine("Enter your account number");
                    accountNumber = Console.ReadLine();
                    Console.WriteLine("Enter your name");
                    var name1 = Console.ReadLine();
                    Console.WriteLine("Enter your phone number");
                    var phoneNumber1 = Console.ReadLine();
                    Console.WriteLine("Enter your account type");
                    var accountType1 = Console.ReadLine();
                    Console.WriteLine("Enter your initial balance");
                    var balance1 = Convert.ToDecimal(Console.ReadLine());
                    var account1 = new Account
                    {
                        AccountNo = accountNumber,
                        AccountName = name1,
                        PhoneNo = phoneNumber1,
                        AccountType = accountType1,
                        Balance = balance1
                    };
                    result = accountService.UpdateAccount(account1);
                    if (result)
                    {
                        Console.WriteLine("Account updated successfully");
                    }
                    else
                    {
                        Console.WriteLine("Account updation failed");
                    }
                    break;
                case "4":
                    Console.WriteLine("Enter your account number");
                    accountNumber = Console.ReadLine();
                    result = accountService.DeleteAccount(accountNumber);
                    if (result)
                    {
                        Console.WriteLine("Account deleted successfully");
                    }
                    else
                    {
                        Console.WriteLine("Account deletion failed");
                    }
                    break;
                case "5":
                    Console.WriteLine("Enter your account number");
                    accountNumber = Console.ReadLine();
                    Console.WriteLine("Enter the amount to deposit");
                    var amount = Convert.ToDecimal(Console.ReadLine());
                    result = accountService.Deposit(accountNumber, amount);
                    if (result)
                    {
                        Console.WriteLine("Amount deposited successfully");
                    }
                    else
                    {
                        Console.WriteLine("Amount deposition failed");
                    }
                    break;
                case "6":
                    Console.WriteLine("Enter your account number");
                    accountNumber = Console.ReadLine();
                    Console.WriteLine("Enter the amount to withdraw");
                    amount = Convert.ToDecimal(Console.ReadLine());
                    result = accountService.Withdraw(accountNumber, amount);
                    if (result)
                    {
                        Console.WriteLine("Amount withdrawn successfully");
                    }
                    else
                    {
                        Console.WriteLine("Amount withdrawal failed");
                    }
                    break;
                case "7":
                    Console.WriteLine("Enter your account number");
                    accountNumber = Console.ReadLine();
                    account = accountService.GetAccountByAccountNumber(accountNumber);
                    if (account != null)
                    {
                        Console.WriteLine($"Account No: {account.AccountNo}");
                        Console.WriteLine($"Account Name: {account.AccountName}");
                        Console.WriteLine($"Account Type: {account.AccountType}");
                        Console.WriteLine($"Account Balance: {account.Balance}");
                        Console.WriteLine($"Account Creation Date: {account.CreationDate}");
                        Console.WriteLine($"Account Phone Number: {account.PhoneNo}");
                        Console.WriteLine("--------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Account not found");
                    }
                    break;
                case "8":
                    Console.WriteLine("Thank you for using XYZ Bank");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to XYZ Bank");
            Console.WriteLine("1. Press 1 to create an account");
            Console.WriteLine("2. Press 2 to display all accounts");
            Console.WriteLine("3. Press 3 to update an account");
            Console.WriteLine("4. Press 4 to delete an account");
            Console.WriteLine("5. Press 5 to deposit an amount into your account");
            Console.WriteLine("6. Press 6 to withdraw an amount from your account");
            Console.WriteLine("7. Press 7 to search an account");
            Console.WriteLine("8. Press 8 to exit");
            Console.WriteLine("Enter your choice");
            var choice = Console.ReadLine();
            var accountService = new AccountService();
            while (choice != "8")
            {
                ProcessChoice(choice, accountService);
                Console.WriteLine("Enter your choice");
                choice = Console.ReadLine();
            }
            
        }
    }
}
