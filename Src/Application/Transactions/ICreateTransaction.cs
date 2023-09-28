namespace Application.Transactions;

public interface ICreateTransaction
{
    Task Create(Transaction transaction);
}