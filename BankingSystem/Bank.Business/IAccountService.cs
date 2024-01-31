using Bank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Business
{
    public interface IAccountService
    {
        bool CreateAccount(Account account);
        bool UpdateAccount(Account account);
        bool DeleteAccount(string AccountNo);
        Account? GetAccountByAccountNumber(string AccountNo);
        List<Account> GetAllAccounts();
        bool Deposit(string AccountNo, decimal amount);
        bool Withdraw(String AccountNo, decimal amount);
        bool DoesExist(string AccountNo);
    }
}
