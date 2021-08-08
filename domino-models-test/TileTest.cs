using System;
using Xunit;
using FluentAssertions;

using domino_models;

namespace domino_models_test
{
    public class TileTest
    {
        [Fact]
        public void tile_0_0_creation()
        {
            Tile tile0_0 = new Tile (0,7);
            Assert.Equal(0,1);
        }
    }
}
