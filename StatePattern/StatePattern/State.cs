namespace StatePattern
{
    public abstract class State
    {
        internal Context Context;

        public void SetContext(Context context)
        {
            Context = context;
        }

        public abstract void ChangeState();
    }
}
