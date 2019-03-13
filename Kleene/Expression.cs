using System;
using System.Collections;
using System.Collections.Generic;

namespace Mu.Kleene
{
    public abstract class Expression
    {
        public abstract IEnumerable<Expression> Expressions { get; }

        public abstract Result Generate();
    }
}
