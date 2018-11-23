using System;
using Xunit;

namespace SticksGame.Tests
{
    public class FactoryTest
    {
        Factory sut;
        public FactoryTest()
        {
            sut = new Factory();
        }

        [Fact]
        public void FactoryShouldReturnViewObject()
        {
            var actual = sut.GetNewView();

            Assert.IsType<View>(actual);
        }
    }
}