﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mu.Kleene
{
    public class CharacterExpression : NullaryExpression
    {
        // TODO: Make this work better with Unicode.
        private readonly Char value;

        public Char Value => this.value;

        public CharacterExpression(Char value)
        {
            this.value = value;
        }

        public override Result Generate() => throw new NotImplementedException();
    }
}
