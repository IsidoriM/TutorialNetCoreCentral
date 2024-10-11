using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDemo.InterpreterPattern.Demo
{
    class Interpreter
    {
        public void Interpret(Context context)
        {
            var expressions = context.Expression.Split(' ');
            var expressionTypes = new List<IExpression>();

            foreach (var expression in expressions)
            {
                if (expression == "-l")
                    expressionTypes.Add(new LowerCaseExpression());
                else if (expression == "-u")
                    expressionTypes.Add(new UpperCaseExpression());
            }

            foreach (var item in expressionTypes)
            {
                item.Evaluate(context);
            }

            Console.WriteLine(context.Value);
        }
    }
}