using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICloneable firstSheep = new Sheep
            {
                Name = "Dolly"
            };

            firstSheep.LogInformation();

            ICloneable shallowCopy = firstSheep.ShallowCopy();
            shallowCopy.LogInformation();

            ICloneable deepCopy = firstSheep.DeepCopy();
            deepCopy.LogInformation();

            Console.ReadKey();
        }
    }
}
