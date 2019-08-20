namespace ChainOfResponsibility
{
    public interface IHandler
    {
        IHandler SetNextHandler(IHandler nextHandler);
        string Handle(string request);
    }

    public abstract class Handler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNextHandler(IHandler nextHandler)
        {
            _nextHandler = nextHandler;
            return nextHandler;
        }

        public virtual string Handle(string request)
        {
            return _nextHandler?.Handle(request);
        }
    }

    public class Chemist : Handler
    {
        public override string Handle(string request)
        {
            if (request.Equals("chemistry"))
                return "I am a chemist and I can do this";

            return base.Handle(request);
        }
    }

    public class Electrician : Handler
    {
        public override string Handle(string request)
        {
            if (request.Equals("electricity"))
                return "Yeah, alright...";

            return base.Handle(request);
        }
    }
}