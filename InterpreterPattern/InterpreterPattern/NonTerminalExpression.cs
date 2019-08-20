namespace InterpreterPattern
{
    public class NonTerminalExpression : IBaseExpression
    {
        public IBaseExpression FirstExpression { get; set; }
        public IBaseExpression SecondExpression { get; set; }

        public void Interpret(Context context)
        {
            FirstExpression.Interpret(context);
            SecondExpression.Interpret(context);
        }
    }
}