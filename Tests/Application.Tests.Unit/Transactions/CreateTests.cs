using Application.Transactions;
using NSubstitute;

namespace Application.Tests.Unit.Transactions;

public class CreateTests
{
    [Fact]
    public async Task Should_Throw_ParamerNullException_If_No_Creator()
    {
        var target = new Create();

        var add = async () => await target.Add(null, new Transaction());

        var actual = await Assert.ThrowsAsync<ArgumentNullException>(add);
        Assert.NotNull(actual.ParamName);
        Assert.NotNull(actual.ParamName);
    }

    [Fact]
    public async Task Should_Throw_ParamerNullException_If_No_Transaction()
    {
        var target = new Create();

        var add = async () => await target.Add(Substitute.For<ICreateTransaction>(), null);

        var actual = await Assert.ThrowsAsync<ArgumentNullException>(add);
        Assert.NotNull(actual.ParamName);
        Assert.NotNull(actual.ParamName);
    }

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
