using System;
using System.Collections.Generic;
using ArithmeticParser.Client.Source;

namespace ArithmeticParser.Client.Interfaces
{
    public interface IParser
    {
        int ParseTokens(List<Token> tokenList);
    }
}
