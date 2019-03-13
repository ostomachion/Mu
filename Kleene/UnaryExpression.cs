using System;
using System.Collections.Generic;
using System.Text;

namespace Mu.Kleene
{
    public abstract class UnaryExpression : Expression
    {
        private readonly Expression expression;

        public Expression Expresion => this.expression;

        public override sealed IEnumerable<Expression> Expressions { get { yield return this.expression; } }

        public UnaryExpression(Expression expression)
        {
            this.expression = expression;
        }
    }
}
