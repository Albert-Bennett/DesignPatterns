using System;

namespace PrototypePattern
{
    public interface ICloneable
    {
        string Id { get; }
        string Name { get; set; }

        ICloneable DeepCopy();
        ICloneable ShallowCopy();

        void LogInformation();
    }

    public class Sheep : ICloneable
    {
        public string Id { get; protected set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }

        public ICloneable DeepCopy()
        {
            Sheep clone = (Sheep)MemberwiseClone();
            clone.Name = string.Copy(Name);
            clone.Id = Guid.NewGuid().ToString();

            return clone;
        }

        public ICloneable ShallowCopy()
        {
            return (Sheep)MemberwiseClone();
        }

        public void LogInformation()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"ID : {Id}");
            Console.WriteLine("------------------------------------------");
        }
    }
}