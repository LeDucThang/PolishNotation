using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolishNotation
{
    public class Operand : IElement
    {
        public string Token { get; }

        public double Value { get; }

        public Operand(string token)
        {
            Token = token;
            Value =  double.TryParse(Token, out double tmp) ? tmp : 0;
        }
    }
}
