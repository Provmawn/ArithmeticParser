# ArithmeticParser
Made with .NET5 Core and Blazor

## Where is the code?

For the application: 
ArithmeticParser/ArithmeticParser/Client/


For the tests: 
ArithmeticParser/ArithmeticParser.Tests/


## How does it work?

Lexer.cs breaks up the string into tokens. 

For example:

1 + 1 becomes

(INTEGER, 1) 

(ARITHMETIC_OPERATOR, +)

(INTEGER, 1)

(END, EOF)


Then this List<Token> is passed to Parser.cs.

The parser then uses the Eat(Type) function to verify that it's getting INTEGER then OPERATOR then INTEGER in that order.

If not it will print an error on the webpage like 'Expected INTEGER, found END'

## The Webpage

The webpage file can be found in the ArithmeticParser/ArithmeticParser/Client/Components folder named Input.razor
