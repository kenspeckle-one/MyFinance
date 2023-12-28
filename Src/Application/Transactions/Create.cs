namespace Application.Transactions;

public class Create
{
    public async Task Add(ICreateTransaction? creator,
        Transaction? transaction) 
    {
        if (creator is null)
        {
            throw new ArgumentNullException(nameof(creator));
        }

        if (transaction is null)
        {
            throw new ArgumentNullException(nameof(transaction));
        }

        await creator.Create(transaction);
    }
}