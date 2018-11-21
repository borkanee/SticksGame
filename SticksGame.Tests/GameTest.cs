using System;
using Xunit;
using Moq;

namespace SticksGame.Tests
{
    public class GameTest
    {
        Game sut;
        Mock<View> viewMock;
        Mock<Sticks> sticksMock;
        Mock<AIPlayer> AIMock;

        public GameTest()
        {
            viewMock = new Mock<View>(new Mock<ConsoleWrapper>().Object);
            sticksMock = new Mock<Sticks>();
            AIMock = new Mock<AIPlayer>();

            sut = new Game(viewMock.Object, sticksMock.Object, AIMock.Object);
        }

        [Fact]
        public void GameShouldCallView()
        {
            sut.Play();
            viewMock.Verify(mock => mock.PresentInstructions());
        }

        [Fact]
        public void GameShouldWaitForInput()
        {
            sut.Play();
            viewMock.Verify(mock => mock.GetInput());
        }

        [Fact]
        public void GameShouldRemoveSticksFromPileAfterUserInput()
        {
            viewMock.Setup(mock => mock.GetInput()).Returns(3);
            sut.Play();
            sticksMock.Verify(mock => mock.RemoveSticks(3));
        }
    }
}