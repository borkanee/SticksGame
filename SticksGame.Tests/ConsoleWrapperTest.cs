using System;
using Xunit;
using Xunit.Abstractions;
using System.IO;

namespace SticksGame
{
    public class ConsoleWrapperTest
    {
        ConsoleWrapper sut;
        public ConsoleWrapperTest()
        {
            sut = new ConsoleWrapper();
        }

        [Fact]
        public void ConsoleWrapperShouldWriteOutput()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                sut.WriteLine("Hello");

                string expected = string.Format("Hello\n");
                Assert.Equal(expected, sw.ToString());
            }
        }

        [Fact]
        public void ConsoleWrapperShouldReadInput()
        {
            using (StringReader sr = new StringReader("1"))
            {
                Console.SetIn(sr);

                string actual = sut.ReadLine();

                string expected = string.Format("1");
                Assert.Equal(expected, actual);
            }
        }
    }
}