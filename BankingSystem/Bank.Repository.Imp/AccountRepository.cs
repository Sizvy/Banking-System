﻿using Bank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Repository.Imp
{
    public class AccountRepository : IAccountRepository
    {
        private readonly List<Account> _accounts;
        public AccountRepository()
        {
            _accounts = new List<Account>();
        }
        public bool CreateAccount(Account account)
        {
            _accounts.Add(account);
            return true;
        }

        public bool DeleteAccount(string AccountNo)
        {
            // search for the account
            var accountToDelete = _accounts.FirstOrDefault(a => a.AccountNo == AccountNo);
            if (accountToDelete == null)
            {
                return false;
            }
            _accounts.Remove(accountToDelete);
            return true;
        }

        public bool Deposit(string AccountNo, decimal amount)
        {
            // search for the account
            var accountToDeposit = _accounts.FirstOrDefault(a => a.AccountNo == AccountNo);
            if (accountToDeposit == null)
            {
                return false;
            }
            accountToDeposit.Balance += amount;
            return true;
        }

        public bool DoesExist(string AccountNo)
        {
            // search for the account
            var accountToCheck = _accounts.FirstOrDefault(a => a.AccountNo == AccountNo);
            if (accountToCheck == null)
            {
                return false;
            }
            return true;
        }

        public Account? GetAccountByAccountNumber(string accountNumber)
        {
            // search for the account
            Account? account = _accounts.FirstOrDefault(a => a.AccountNo == accountNumber);
            return account;
        }

        public List<Account> GetAllAccounts()
        {
            return _accounts;
        }

        public bool UpdateAccount(Account account)
        {
            // search for the account
            var accountToUpdate = _accounts.FirstOrDefault(a => a.AccountNo == account.AccountNo);
            if (accountToUpdate == null)
            {
                return false;
            }
            if(account.AccountName != "")
                accountToUpdate.AccountName = account.AccountName;
            if(account.PhoneNo != "")
                accountToUpdate.PhoneNo = account.PhoneNo;
            return true;
        }

        public bool Withdraw(string AccountNo, decimal amount)
        {
            // search for the account
            var accountToWithdraw = _accounts.FirstOrDefault(a => a.AccountNo == AccountNo);
            if (accountToWithdraw == null)
            {
                return false;
            }
            if(accountToWithdraw.Balance < amount || accountToWithdraw.Balance - amount < 500)
            {
                return false;
            }
            accountToWithdraw.Balance -= amount;
            return true;
        }
    }
}
