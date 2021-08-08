using Xunit;
using FluentAssertions;
using domino.models;

namespace domino_models_test
{
  public class DominoSetTest
  {
    [Fact]
    public void dominoset_creation()
    {
      DominoSet dominoSet = new DominoSet(6);

      dominoSet.Should().BeOfType<DominoSet>();
      dominoSet.Size().Should().Be(28);
    }
  }
}