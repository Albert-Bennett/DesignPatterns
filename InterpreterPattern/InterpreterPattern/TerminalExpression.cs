using System;

namespace InterpreterPattern
{
    public class TerminalExpression : IBaseExpression
    {
        public void Interpret(Context context)
        {
            Console.WriteLine(context.Name);
        }
    }
}
