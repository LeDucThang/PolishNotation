using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolishNotation
{
    public class MathParser
    {
        public enum TokenType
        {
            None,
            Alphabet,
            Digit,
            Comma,
            Operator
        }

        public MathParser()
        {

        }
        public bool Parse(string expression)
        {
            expression = expression.Replace(" ", "");
            int index = 0;
            TokenType type = TokenType.None;
            StringBuilder builder = new StringBuilder("");
            List<IElement> elements = new List<IElement>();
            while (index < expression.Length)
            {
                if (type == TokenType.None)
                {
                    type = GetTokenType(expression[index]);
                    builder = new StringBuilder("");
                }

                if (type != TokenType.None && type != GetTokenType(expression[index]))
                {
                    if (type == TokenType.Alphabet)
                    {
                        Function function = new Function(builder.ToString());
                        elements.Add(function);
                    }
                    if (type == TokenType.Digit)
                    {
                        Operand operand = new Operand(builder.ToString());
                        elements.Add(operand);
                    }
                    if (type == TokenType.Comma)
                    {
                        Comma comma = new Comma(builder.ToString());
                        elements.Add(comma);
                    }
                    if (type == TokenType.Operator)
                    {
                        Operator op = new Operator(builder.ToString());
                        elements.Add(op);
                    }
                    type = TokenType.None;
                    continue;
                }

                builder.Append(expression[index]);
                index++;
            }
            return false;
        }

        private TokenType GetTokenType(char c)
        {
            if (('A' <= c && c <= 'Z') || ('a' <= c && c <= 'z')) return TokenType.Alphabet;
            if (c == ',') return TokenType.Comma;
            if (('0' <= c && c <= '9') || '.' == c) return TokenType.Digit;
            if (c == '=' || c == '>' || c == '<' || c == '+' || c == '-' || c == '*' || c == '/' || c == '(' || c == ')') return TokenType.Operator;
            return TokenType.None;
        }
    }
}
