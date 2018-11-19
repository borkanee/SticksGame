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
            sticksMock.Setup(mock => mock.RemoveSticks(3)).Verifiable();
            sut.Play(sticksMock.Object);
            sticksMock.Verify();
        }
    }
}