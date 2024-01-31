using Bank.Model;

namespace Bank.Repository
{
    public interface IAccountRepository
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
