using System;

namespace Bank.App
{
    internal class Program
    {
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
                        Name = name,
                        PhoneNumber = phoneNumber,
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
                    foreach (var account1 in accounts)
                    {
                        Console.WriteLine(account1);
                    }
                    break;
                case "3":
                    Console.WriteLine("Enter your account number");
                    var accountNumber = Console.ReadLine();
                    Console.WriteLine("Enter your name");
                    var name1 = Console.ReadLine();
                    Console.WriteLine("Enter your address");
                    var address1 = Console.ReadLine();
                    Console.WriteLine("Enter your phone number");
                    var phoneNumber1 = Console.ReadLine();
                    Console.WriteLine("Enter your account type");
                    var accountType1 = Console.ReadLine();
                    Console.WriteLine("Enter your initial balance");
                    var balance1 = Convert.ToDecimal(Console.ReadLine());
                    var account1 = new Account
                    {
                        AccountNo = accountNumber,
                        Name = name1,
                        Address = address1,
                        PhoneNumber = phoneNumber1,
                        AccountType = accountType1,
                        Balance = balance1
                    };
                    var result1 = accountService.UpdateAccount(account1);
                    if (result1)
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
                    var accountNumber2 = Console.ReadLine();
                    var result2 = accountService.DeleteAccount(accountNumber2);
            }
        }
    }
}
