namespace Application.Transactions;

public class Create
{
    public async Task Add(ICreateTransaction? creator,
        Transaction? transaction) 
    {
        // TODO: Test the creator and transaction are not null.
        await creator.Create(transaction);
    }
}
