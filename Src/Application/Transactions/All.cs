namespace Application;

public class All
{
    public async Task<List<Transaction>> GetAsync(IGetAllTransactions allTransactions,
        CancellationToken cancellationToken)
    {
        return await allTransactions.GetAsync(cancellationToken);
    }
}