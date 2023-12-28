namespace Application;

public interface IGetAllTransactions
{
    Task<List<Transaction>> GetAsync(CancellationToken cancellationToken);
}