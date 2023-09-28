using Application.Transactions;
using NSubstitute;

namespace Application.Tests.Unit.Transactions;

public class CreateTests
{
    [Fact]
    public async Task Should_Persist_The_Transaction()
    {
        var transaction = new Transaction() {
            Id = new TransactionId(),
            Description = "Test Transaction"
        };

        var creator = Substitute.For<ICreateTransaction>();

        var target = new Create();

        await target.Add(creator, transaction);

        await creator.Received().Create(transaction);
    }
}
