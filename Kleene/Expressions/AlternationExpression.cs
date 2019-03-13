using System;
using System.Collections.Generic;
using System.Text;

namespace Mu.Kleene
{
    public class AlternationExpression : VariadicExpression
    {
        public AlternationExpression(IEnumerable<Expression> expressions)
            : base(expressions) { }

        public override Result Generate() => throw new NotImplementedException();
    }
}
