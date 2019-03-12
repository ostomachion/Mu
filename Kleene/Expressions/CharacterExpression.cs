using System;
using System.Collections.Generic;
using System.Text;

namespace Kleene
{
    public class CharacterExpression : NullaryExpression
    {
        private readonly Char value;

        public Char Value => this.value;

        public CharacterExpression(Char value)
        {
            this.value = value;
        }

        public override ResultTree Generate() => throw new NotImplementedException();
    }
}
