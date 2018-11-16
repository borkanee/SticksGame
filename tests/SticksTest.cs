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
    }
}