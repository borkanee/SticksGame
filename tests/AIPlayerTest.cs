using System;
using Xunit;
using Moq;

namespace SticksGame
{
    public class AIPlayerTest
    {
        AIPlayer sut = new AIPlayer();
        
        
        [Fact]
        public void AIPlayerShouldRemoveSticks()
        {
            Mock<Sticks> sticksMock = new Mock<Sticks>();
            sticksMock.Setup(mock => mock.RemoveSticks(3)).Verifiable();
            sut.Play(sticksMock.Object);
            sticksMock.Verify();
        }
    }
}