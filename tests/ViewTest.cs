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
    }
}