namespace Kata.Tests;

[TestFixture]
public class ReversedStringTestsTests
{
  [Test]
  public void ReversedStringTestsTest()
  {
    Assert.AreEqual("dlrow", ReversedString.Solution("world"));
  }
}