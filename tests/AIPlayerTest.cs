using System;
using Xunit;
using Moq;

namespace SticksGame
{
    public class AIPlayerTest
    {
        AIPlayer sut = new AIPlayer();
        Mock<Sticks> sticksMock = new Mock<Sticks>();
        
        [Fact]
        public void AIPlayerShouldRemoveSticks()
        {
            sticksMock.Setup(mock => mock.RemoveSticks(3)).Verifiable();
            sut.Play(sticksMock);
            sticksMock.Verify();
        }
    }
}