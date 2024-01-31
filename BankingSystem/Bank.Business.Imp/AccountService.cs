using Bank.Model;
using Bank.Repository;
using Bank.Repository.Imp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Business.Imp
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService()
        {
            _accountRepository = new AccountRepository();
        }
        public bool CreateAccount(Account account)
        {
            if(account == null)
            {
                return false;
            }
            return _accountRepository.CreateAccount(account);
        }

        public bool DeleteAccount(string AccountNo)
        {
            return _accountRepository.DeleteAccount(AccountNo);
        }

        public bool Deposit(string AccountNo, decimal amount)
        {
            return _accountRepository.Deposit(AccountNo, amount);
        }

        public bool DoesExist(string AccountNo)
        {
            return _accountRepository.DoesExist(AccountNo);
        }

        public Account? GetAccountByAccountNumber(string AccountNo)
        {
            return _accountRepository.GetAccountByAccountNumber(AccountNo);
        }

        public List<Account> GetAllAccounts()
        {
            return _accountRepository.GetAllAccounts();
        }

        public bool UpdateAccount(Account account)
        {
            return _accountRepository.UpdateAccount(account);
        }

        public bool Withdraw(string AccountNo, decimal amount)
        {
            return _accountRepository.Withdraw(AccountNo, amount);
        }
    }
}
