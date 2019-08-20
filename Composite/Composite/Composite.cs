namespace Composite
{
    public class Composite : Component
    {
        public override string Action()
        {
            string result = string.Empty;

            foreach (Component comp in Children.Value)
            {
                result += $"{comp.Action()} ";
            }

            return result;
        }
    }
}
