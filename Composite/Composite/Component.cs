using System;
using System.Collections.Generic;

namespace Composite
{
    public abstract class Component
    {
        protected Lazy<IList<Component>> Children { get; } =
            new Lazy<IList<Component>>(() => new List<Component>());

        public virtual bool IsComposite { get; } = true;

        public abstract string Action();

        public virtual void AddComponent(Component component)
        {
            if (!IsComposite)
                return;

            if (!Children.Value.Contains(component))
                Children.Value.Add(component);
        }

        public virtual void RemoveComponent(Component component)
        {
            if (!IsComposite)
                return;

            if (Children.Value.Contains(component))
                Children.Value.Remove(component);
        }
    }
}
