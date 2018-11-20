using System;
using Xunit;
using Moq;

namespace SticksGame
{
    public class ViewTest
    {
        View sut;
        Mock<ConsoleWrapper> consoleMock;

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
        public void ViewShouldGetInput()
        {
            consoleMock.Setup(mock => mock.ReadLine()).Returns("1");
            int actual = sut.GetInput();
            int expected = 1;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ViewShouldOnlyAcceptIntegers()
        {
            consoleMock.SetupSequence(mock => mock.ReadLine())
                .Returns("one")
                .Returns("1");
            int actual = sut.GetInput();
            int expected = 1;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ViewShouldOnlyAcceptIntegersBetweenOneAndThree()
        {
            consoleMock.SetupSequence(mock => mock.ReadLine())
                .Returns("4")
                .Returns("3");
            int actual = sut.GetInput();
            int expected = 3;
            Assert.Equal(expected, actual);
        }
    }
}