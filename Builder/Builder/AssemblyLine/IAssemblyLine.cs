using Builder.Cars;

namespace Builder.AssemblyLine
{
    public interface IAssemblyLine
    {
        IAssemblyLine SetName();

        IAssemblyLine MakeMake();

        IAssemblyLine PaintCar();

        Car GetCar();
    }
}
