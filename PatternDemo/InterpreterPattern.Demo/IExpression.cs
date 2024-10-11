using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDemo.InterpreterPattern.Demo
{
    internal interface IExpression
    {
        void Evaluate(Context context);
    }
}
