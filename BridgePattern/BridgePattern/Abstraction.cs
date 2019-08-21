using System;

namespace BridgePattern
{
    public abstract class Abstraction
    {
        protected IImplementor _implementor;

        public IImplementor Implementor
        {
            set => _implementor = value;
        }

        public virtual void Speak()
        {
            _implementor.Speak();
        }
    }

    public class SpeakerCoordinator : Abstraction
    {
        public override void Speak()
        {
            Console.WriteLine("The next speaker will speak");
            base.Speak();
        }
    }
}
