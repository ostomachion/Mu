﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kleene
{
    public class ConcatenationExpression : VariadicExpression
    {
        public ConcatenationExpression(IEnumerable<Expression> expressions)
            : base(expressions) { }

        public override ResultTree Generate() => throw new NotImplementedException();
    }
}
