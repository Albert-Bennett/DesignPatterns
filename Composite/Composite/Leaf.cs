namespace Composite
{
    public class Leaf : Component
    {
        public override bool IsComposite { get; } = false;

        public override string Action()
        {
            return "I am a leaf";
        }
    }
}