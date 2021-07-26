using System.Text;
using System.Collections.Generic;
using ArithmeticParser.Client.Source;

namespace ArithmeticParser.Client.Interfaces
{
    public interface ILexer
    {
        List<Token> GrabTokens(string text);
    }
}
