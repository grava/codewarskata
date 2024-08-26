using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Kata.Tests;

[TestFixture]
public class SquareNumTests
{
  private static IEnumerable<TestCaseData> sampleTestCases
  {
    get
    {
      yield return new TestCaseData(new[]{1,2,2}).Returns(9);
      yield return new TestCaseData(new[]{1,2}).Returns(5);
      yield return new TestCaseData(new[]{5,3,4}).Returns(50);
      yield return new TestCaseData(new int[] {}).Returns(0);
    }
  }

  [Test, TestCaseSource("sampleTestCases"), Description("Sample Tests")]
  public int SampleTest(int[] n) => SquarenSum.SquareSum(n);
}
