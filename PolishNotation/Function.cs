using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolishNotation
{
    public class Function : IElement
    {
        public string Token { get; private set; }
        public FunctionType Type { get; }

        public Function(string token)
        {
            Token = token;
            if (token.ToLower() == FunctionType.IF.ToString().ToLower()) Type = FunctionType.IF;
            if (token.ToLower() == FunctionType.SUM.ToString().ToLower()) Type = FunctionType.SUM;
            if (token.ToLower() == FunctionType.AVG.ToString().ToLower()) Type = FunctionType.AVG;
            if (token.ToLower() == FunctionType.COUNT.ToString().ToLower()) Type = FunctionType.COUNT;

        }
    }

    public enum FunctionType
    {
        IF,
        SUM,
        AVG,
        COUNT
    }
}
