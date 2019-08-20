using System;

namespace StatePattern
{
    public class StateA : State
    {
        public override void ChangeState()
        {
            Console.WriteLine("Changing from StateA to State B");
            Context.TransitionState(new StateB());
        }
    }

    public class StateB : State
    {
        public override void ChangeState()
        {
            Console.WriteLine("Changing from StateB to State A");
            Context.TransitionState(new StateA());
        }
    }
}