namespace _5_Exceptions
{
    public class BancAccount
    {
        public BancAccount(int _balance)
        {
            if(_balance < 0)
            {
                throw new InsufficientFundsException();
            }
            Balance = _balance;
        }
        int Balance;
        public void Deposit(int amount)
        {
            Balance += amount;
        }
        public void Withdraw(int amount)
        {
            if (Balance-amount<0)
            {
                throw new InsufficientFundsException();
            }
            Balance -= amount; 
        }
    }
}
