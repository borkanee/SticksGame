using System;
using Xunit;

namespace SticksGame.Tests
{
    public class SticksTest
    {
        Sticks sut = new Sticks();

        [Fact]
        public void SticksShouldHaveTwentyOneSticksFromStart()
        {
            int actual = sut.Amount;
            int expected = 21;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldRemoveSticks()
        {
            sut.RemoveSticks(3);
            int actual = sut.Amount;
            int expected = 18;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldThrowExceptionWhenArgumentIsOutOfRange()
        {
            Assert.Throws<ArgumentOutOfRangeException>(()=> sut.RemoveSticks(10));
        }
    }
}