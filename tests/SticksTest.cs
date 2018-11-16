using System;
using Xunit;

namespace SticksGame
{
    public class SticksTest
    {


        [Fact]
        public void sticksShouldBeInstantiatedWithoutParameters() {
            Sticks sut = new Sticks();
        }

        [Fact]
        public void SticksShouldHaveTwentyOneSticksFromStart()
        {

            Sticks sut = new Sticks();
            int actual = sut.NumberOfSticks;
            int expected = 21;
            Assert.Equal(expected, actual);
        }
    }
}