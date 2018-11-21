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
        public void GameShouldRemoveSticksFromPileAfterUserInput()
        {
            viewMock.Setup(mock => mock.GetInput()).Returns(3);
            sut.Play();
            sticksMock.Verify(mock => mock.RemoveSticks(3));
        }

        [Fact]
        public void GameShouldPresentAIPlayerAsWinner()
        {
            sticksMock.SetupGet(mock => mock.Amount).Returns(0);

            sut.Play();

            viewMock.Verify(mock => mock.PresentWinner("AIPlayer"));

        }

        [Fact]
        public void GameShouldPresentPlayerAsWinner()
        {
            sticksMock.SetupSequence(mock => mock.Amount)
            .Returns(3)
            .Returns(0);

            sut.Play();

            viewMock.Verify(mock => mock.PresentWinner("Player"));
        }

        [Fact]
        public void GameShouldRunThroughTheWholeLoop()
        {
            sticksMock.SetupSequence(mock => mock.Amount)
            .Returns(10)
            .Returns(10)
            .Returns(10)
            .Returns(10)
            .Returns(10)
            .Returns(0);
            
            sut.Play();
    
            viewMock.Verify(mock => mock.PresentWinner("AIPlayer"));
        }
    }
}