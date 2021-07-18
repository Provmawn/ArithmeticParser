using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArithmeticParser.Client.Source
{
    public class Parser
    {
        private int _position;
        private List<Token> _tokenList = new List<Token>();
        private Token _currentToken = null;
        public Parser()
        {
        }

        public int ParseTokens(List<Token> tokenList)
        {
            _tokenList = tokenList;
            _position = 0;
            _currentToken = _tokenList[_position];
            int result = int.Parse(Eat(Type.INTEGER));
            Advance();
            while (_currentToken.Type != Type.END)
            {
                string op = Eat(Type.ARITHMETIC_OPERATOR);
                Advance();
                int x = int.Parse(Eat(Type.INTEGER));
                Advance();
                if (op == "+")
                {
                    result += x;
                }
                else if (op == "-")
                {
                    result -= x;
                }
                else if (op == "*")
                {
                    result *= x;
                }
                else if (op == "/")
                {
                    result /= x;
                }
            }
            return result;
        }
        private string Eat(Type type)
        {
            if (_currentToken.Type != type)
            {
                throw new Exception($"Expected type {type}, found {_currentToken.Type}");
            }
            return _currentToken.Value;
        }
        private void Advance()
        {
            if (_tokenList.Count > _position)
            {
                ++_position;
                _currentToken = _tokenList[_position];
            }
        }
    }
}
