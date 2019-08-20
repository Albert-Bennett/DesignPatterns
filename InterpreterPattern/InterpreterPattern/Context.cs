namespace InterpreterPattern
{
    public class Context
    {
        public string Name { get; }

        //Other properties that expressions can rely upon

        public Context(string name)
        {
            Name = name;
        }
    }
}
