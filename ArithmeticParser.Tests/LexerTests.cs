using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ArithmeticParser.Client.Source;

namespace ArithmeticParser.Tests
{
    public class LexerTests
    {
        [Fact]
        public void GrabTokens_TokenListLengthEmptyString()
        {
            // Arrange
            Lexer lexer = new Lexer();
            int expected = 1;

            // Act
            int actual = lexer.GrabTokens("").Count;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GrabTokens_IncompleteExpression()
        {
            // Arrange
            Lexer lexer = new Lexer();
            int expected = 3;

            // Act
            int actual = lexer.GrabTokens("2 + ").Count;

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}
