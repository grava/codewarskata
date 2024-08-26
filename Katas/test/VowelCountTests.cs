[TestFixture]
public class VowelCountTests
{
    [Test]
    public void TestCase1()
    {
        Assert.AreEqual(5, VowelCount.GetVowelCount("abracadabra"));
    }
}
