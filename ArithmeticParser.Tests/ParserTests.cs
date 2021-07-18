using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ArithmeticParser.Client.Source;

namespace ArithmeticParser.Tests
{
    public class ParserTests
    {
        [Theory]
        [InlineData(0, 0, "+", 0)]
        [InlineData(6, 5, "+", 11)]
        [InlineData(6, 6, "+", 12)]
        [InlineData(6, 7, "+", 13)]
        public void ParseTokens_CheckAddition(int operand1, int operand2, string operation, int expected)
        {
            // Arrange
            List<Token> tokenList = new List<Token>();
            tokenList.Add(new Token(Client.Source.Type.INTEGER, operand1.ToString()));
            tokenList.Add(new Token(Client.Source.Type.ARITHMETIC_OPERATOR, operation));
            tokenList.Add(new Token(Client.Source.Type.INTEGER, operand2.ToString()));

            Parser parser = new Parser();

            // Act
            int actual = parser.ParseTokens(tokenList);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
