using AbstractFactory.Objects;

namespace AbstractFactory.Factory
{
    public interface IMyFactory
    {
        IMyObject CreateInstance(); 
    }
}
