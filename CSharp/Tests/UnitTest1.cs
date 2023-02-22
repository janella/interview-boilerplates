using Lib;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var sut = new Class1();
        var list = new List<int>();
        sut.Execute();
    }
}