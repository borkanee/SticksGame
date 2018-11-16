using System;
using Xunit;

namespace SticksGame
{
    public class SticksTest
    {

        [Fact]
        public void constructor_should_be_called_without_parameters() {
            Sticks sut = new Sticks();
        }
    }
}