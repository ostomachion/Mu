using System;
using System.Collections.Generic;
using System.Text;

namespace Kleene
{
    public abstract class VariadicExpression : Expression
    {
        private readonly IEnumerable<Expression> expressions;

        public override sealed IEnumerable<Expression> Expressions => this.expressions;

        public VariadicExpression(IEnumerable<Expression> expressions)
        {
            this.expressions = expressions;
        }
    }
}
