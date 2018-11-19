using System;
using Xunit;
using Moq;

namespace SticksGame
{
    public class AIPlayerTest
    {
        AIPlayer sut;
        Mock<Sticks> sticksMock;
        public AIPlayerTest()
        {
            sut = new AIPlayer();
            sticksMock = new Mock<Sticks>();
        }
        
        [Fact]
        public void AIPlayerShouldCallRemoveSticks()
        {
            sut.Play(sticksMock.Object);
            sticksMock.Verify(mock => mock.RemoveSticks(3));
        }

        [Fact]
        public void AIPlayerShouldRemoveTwoSticksIfThreeLeft()
        {
            sticksMock.SetupGet(mock => mock.Amount).Returns(3);
            sut.Play(sticksMock.Object);
            sticksMock.Verify(mock => mock.RemoveSticks(2));
        }
    }
}