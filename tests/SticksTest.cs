using System;
using Xunit;

namespace SticksGame
{
    public class SticksTest
    {
        Sticks sut = new Sticks();

        [Fact]
        public void SticksShouldHaveTwentyOneSticksFromStart()
        {
            int actual = sut.NumberOfSticks;
            int expected = 21;
            Assert.Equal(expected, actual);
        }
    }
}