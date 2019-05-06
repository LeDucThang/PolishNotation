using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolishNotation
{
    public class Operator : IElement
    {
        public string Token { get; }
        public int Priority { get; }

        public Operator(string token)
        {
            Token = token;
            switch (Token)
            {
                case "*":
                case "/":
                    Priority = 3;
                    break;
                case "+":
                case "-":
                    Priority = 2;
                    break;
                case "<":
                case ">":
                case "=":
                case "<=":
                case ">=":
                    Priority = 1;
                    break;
                case "(":
                case ")":
                    Priority = 0;
                    break;
            }
        }
    }
}
