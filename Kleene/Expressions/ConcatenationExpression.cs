using System;
using System.Collections.Generic;
using System.Text;

namespace Mu.Kleene
{
    public class ConcatenationExpression : VariadicExpression
    {
        public ConcatenationExpression(IEnumerable<Expression> expressions)
            : base(expressions) { }

        public override Result Generate() => throw new NotImplementedException();
    }
}
