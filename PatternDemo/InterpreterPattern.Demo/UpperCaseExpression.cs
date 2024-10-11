using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDemo.InterpreterPattern.Demo
{
    internal class UpperCaseExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            context.Value = context.Value.ToUpper();
        }
    }
}
