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

            Mock<Factory> factoryMock = new Mock<Factory>();
            factoryMock.Setup(mock => mock.GetNewView()).Returns(viewMock.Object);
            factoryMock.Setup(mock => mock.GetNewSticks()).Returns(sticksMock.Object);
            factoryMock.Setup(mock => mock.GetNewAIPlayer()).Returns(AIMock.Object);

            sut = new Game(factoryMock.Object);
        }

        [Fact]
        public void GameShouldCallFactoryNewView()
        {
            var factoryMock = new Mock<Factory>();
            var sut = new Game(factoryMock.Object);

            factoryMock.Verify(mock => mock.GetNewView());
        }

        [Fact]
        public void GameShouldCallFactoryNewSticks()
        {
            var factoryMock = new Mock<Factory>();
            var sut = new Game(factoryMock.Object);

            factoryMock.Verify(mock => mock.GetNewSticks());
        }

        [Fact]
        public void GameShouldCallFactoryNewAI()
        {
            var factoryMock = new Mock<Factory>();
            var sut = new Game(factoryMock.Object);

            factoryMock.Verify(mock => mock.GetNewAIPlayer());
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

        [Fact]
        public void GameShouldPresentNumberOfSticksLeft()
        {
            sut.Play();

            viewMock.Verify(mock => mock.PresentNumberOfSticksLeft(sticksMock.Object));
        }

        [Fact]
        public void GameShouldDisplayAIAsCurrentPlayer()
        {
            sticksMock.SetupSequence(mock => mock.Amount)
            .Returns(10)
            .Returns(10)
            .Returns(0);

            sut.Play();

            viewMock.Verify(mock => mock.DisplayAIPlayerAsCurrentPlayer());
        }
    }
}