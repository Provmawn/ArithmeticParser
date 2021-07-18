using System.Collections.Generic;
using System.Text;
using System;

namespace ArithmeticParser.Client.Source
{
    public enum Type
    { 
        END,
        INTEGER,
        ARITHMETIC_OPERATOR
    }
    public class Token
    {
        public Type Type { get; set; }
        public string Value { get; set; }
        public Token(Type type, string value)
        {
            Type = type;
            Value = value;
        }
    }
    public class Lexer
    {
        private List<Token> _tokenList;
        private StringBuilder _text;
        private int _position = 0;
        public List<Token> GrabTokens(string text)
        {
            _text = new StringBuilder(text);
            _tokenList = new List<Token>();
            _position = 0;

            while (KeepReading())
            {
                char current = _text[_position];
                SkipWhiteSpace();
                if (Char.IsDigit(current))
                {
                    _tokenList.Add(ReadDigit());
                }

                if (IsOperator(current))
                {
                    _tokenList.Add(ReadOperator());
                }

            }
            _tokenList.Add(new Token(Type.END, "EOF"));
            return _tokenList;
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            foreach (Token token in _tokenList)
                output.Append($"{token.Type} {token.Value}\n");
            return output.ToString();
        }
        private Token ReadOperator()
        {
            StringBuilder operatorString = new StringBuilder();
            while (KeepReading() && IsOperator(_text[_position]))
            {
                operatorString.Append(_text[_position]);
                ++_position;
            }
            return new Token(Type.ARITHMETIC_OPERATOR, operatorString.ToString());
        }
        private Token ReadDigit()
        {
            StringBuilder integerString = new StringBuilder();
            while (KeepReading() && Char.IsDigit(_text[_position]))
            {
                integerString.Append(_text[_position]);
                ++_position;
            }
            return new Token(Type.INTEGER, integerString.ToString());
        }
        private bool IsOperator(char character)
        {
            return character == '+' || character == '-' || character == '*' || character == '/';
        }
        private bool KeepReading()
        {
            return _position < _text.Length;
        }
        private void SkipWhiteSpace()
        {
            while (KeepReading() && Char.IsWhiteSpace(_text[_position]))
            {
                ++_position;
            }
        }
    }
}
