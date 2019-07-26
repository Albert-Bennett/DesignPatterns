using AbstractFactory.Objects;

namespace AbstractFactory.Factory
{
    public class MyFactory : IMyFactory
    {
        public IMyObject CreateInstance()
        {
            return new MyObject();
        }
    }
}
