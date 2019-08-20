namespace InterpreterPattern
{
    public interface IClient
    {
        void Execute();
    }

    public class Client : IClient
    {
        private readonly Context _context;
        private readonly NonTerminalExpression _root;

        public Client()
        {
            _context = new Context("Test Context");

            _root = new NonTerminalExpression
            {
                FirstExpression = new TerminalExpression(),
                SecondExpression = new TerminalExpression()
            };

        }

        public void Execute()
        {
            _root.Interpret(_context);
        }
    }
}