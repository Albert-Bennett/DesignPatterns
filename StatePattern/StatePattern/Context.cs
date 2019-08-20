namespace StatePattern
{
    public class Context
    {
        private State _currentState;

        public Context(State state)
        {
            TransitionState(state);
        }

        public void TransitionState(State state)
        {
            state.SetContext(this);
            _currentState = state;
        }

        public void ChangeState()
        {
            _currentState.ChangeState();
        }
    }
}