using static System.Math;
using Xunit;
using FluentAssertions;
using domino.models;
using System;
using static domino.models.Utils;

namespace domino_models_test
{
  public class UtilsTest
  {
    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(3, 6)]
    [InlineData(4, 24)]
    [InlineData(5, 120)]
    public void FactorialTest(int n, int expected)
    {
      int result = factorial(n);
      result.Should().Be(expected);
    }

    [Fact]
    public void InvalidArgumentFactorial()
    {
      Action act = () =>
      {
        int result = factorial(-1);
      };
      act.Should().Throw<ArgumentOutOfRangeException>().WithMessage("Specified argument was out of the range of valid values. (Parameter 'There is no implementation of factorial of negative numbers.')");
    }

    [Theory]
    [InlineData(2, 6)]
    [InlineData(3, 10)]
    [InlineData(4, 15)]
    [InlineData(5, 21)]
    [InlineData(6, 28)]
    [InlineData(7, 36)]
    [InlineData(8, 45)]
    [InlineData(9, 55)]
    [InlineData(10, 66)]
    public void DominoSetSizeTest(int maxpips, int expected_size)
    {
      int result = DominoSetSize(maxpips);
      result.Should().Be(expected_size);
    }
  }
}
