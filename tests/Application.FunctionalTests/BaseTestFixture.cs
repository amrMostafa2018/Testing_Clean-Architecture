namespace CleanArchitecture.Application.FunctionalTests;

using static Testing;

[TestFixture]
public abstract class BaseTestFixture
{
    [SetUp]
    //Run code before each test
    public async Task TestSetUp()
    {
        await ResetState();
    }
}
