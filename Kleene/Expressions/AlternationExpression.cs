﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kleene
{
    public class AlternationExpression : VariadicExpression
    {
        public AlternationExpression(IEnumerable<Expression> expressions)
            : base(expressions) { }

        public override ResultTree Generate() => throw new NotImplementedException();
    }
}