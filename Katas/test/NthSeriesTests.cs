[TestFixture]
public class NthSeriesTests
{

    [Test]
    public void Test1()
    {
        Assert.That(Kata.SumOfSeries.seriesSum(0), Is.EqualTo("0.00"));
    }
    [Test]
    public void Test2()
    {
        Assert.That(Kata.SumOfSeries.seriesSum(9), Is.EqualTo("1.77"));
    }

}