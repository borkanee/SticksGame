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

        [Fact]
        public void FactoryShouldReturnSticksObject()
        {
            var actual = sut.GetNewSticks();

            Assert.IsType<Sticks>(actual);
        }

        [Fact]
        public void FactoryShouldReturnAIPlayerObject()
        {
            var actual = sut.GetNewAIPlayer();

            Assert.IsType<AIPlayer>(actual);
        }
    }
}