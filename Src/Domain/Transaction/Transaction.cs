namespace Domain;
    
[StronglyTypedId]
public partial struct TransactionId {}

public class Transaction
{
    public TransactionId Id { get; set; }
    public string Description { get; set; } = string.Empty;        
}
