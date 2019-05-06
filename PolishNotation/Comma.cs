using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolishNotation
{
    public class Comma : IElement
    {
        public string Token { get; }

        public Comma(string token)
        {
            Token = token;
        }
    }
}
