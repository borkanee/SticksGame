using System;
using Xunit;
using Moq;

namespace SticksGame.Tests
{
    public class ViewTest
    {
        View sut;
        Mock<ConsoleWrapper> consoleMock;
        Mock<Sticks> sticksMock;

        public ViewTest()
        {
            consoleMock = new Mock<ConsoleWrapper>();
            sut = new View(consoleMock.Object);
        }

        [Fact]
        public void ViewShouldPresentInstructions()
        {
            sut.PresentInstructions();
            consoleMock.Verify(mock => mock.WriteLine("Welcome! Enter the number of sticks you want to take (1-3):"));
        }

        [Fact]
        public void ViewShouldOnlyAcceptAnIntegerBetweenOneAndThree()
        {
            consoleMock.SetupSequence(mock => mock.ReadLine())
                .Returns("5")
                .Returns("0")
                .Returns("-10")
                .Returns(">+?")
                .Returns("five")
                .Returns("4")
                .Returns("3");
            int actual = sut.GetInput();
            int expected = 3;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ViewShouldPresentInformationIfWrongInput()
        {
            consoleMock.SetupSequence(mock => mock.ReadLine()).Returns("0").Returns("1");
            int actual = sut.GetInput();
            consoleMock.Verify(mock => mock.WriteLine("Please enter a valid number of sticks:"));
        }

        [Fact]
        public void ViewShouldPresentNumberOfSticksLeft()
        {
            sticksMock = new Mock<Sticks>();
            sticksMock.SetupGet(mock => mock.Amount).Returns(10);
            sut.PresentNumberOfSticksLeft(sticksMock.Object);
            consoleMock.Verify(mock => mock.WriteLine("There are 10 number of sticks left!"));
        }

        [Fact]
        public void ViewShouldPresentWinner()
        {
            sut.PresentWinner("AI");
            consoleMock.Verify(mock => mock.WriteLine("AI won the game!"));
        }

        [Fact]
        public void ViewShouldDisplayWhenAIPlayerIsPlaying()
        {
            sut.DisplayAIPlayerAsCurrentPlayer();
            consoleMock.Verify(mock => mock.WriteLine("AI plays..."));
        }
    }
}