namespace Spender.ViewModel;
public class CategoryViewModel
{
    public Guid Id {get; set;}
    public required string Name {get; set;}
    public Guid ClientId {get;set;}
    public TransactionType TransactionType {get;set;}
}

public enum TransactionType
{
    Income,
    Expense
}