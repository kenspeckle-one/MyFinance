using NSubstitute;

namespace Application.Tests.Unit;

public class AllTests
{
    [Fact]
    public async Task Should_Load_All_Transactions()
    {
        var allTransactions = new List<Transaction>();
        var cancellationToken = CancellationToken.None;

        var all = new All();
        
        var dataSource = Substitute.For<IGetAllTransactions>();
        dataSource.GetAsync(cancellationToken).Returns(allTransactions);

        var actual = await all.GetAsync(dataSource, cancellationToken);

        Assert.Same(allTransactions, actual);
    }
}