using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        int n = 2;
        int m = 2;

        var expected = 2;
        var actual = Result.towerBreakers(n,m);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        int n = 1;
        int m = 4;

        var expected = 1;
        var actual = Result.towerBreakers(n,m);

        Assert.Equal(expected, actual);
    }
}