﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kleene
{
    public abstract class NullaryExpression : Expression
    {
        public override sealed IEnumerable<Expression> Expressions => Enumerable.Empty<Expression>();
    }
}
