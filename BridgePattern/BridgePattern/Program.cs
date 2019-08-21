using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction speakerCoordinator = new SpeakerCoordinator();
            speakerCoordinator.Implementor = new FirstSpeaker();
            speakerCoordinator.Speak();

            Console.WriteLine();

            speakerCoordinator.Implementor = new SecondSpeaker();
            speakerCoordinator.Speak();

            Console.ReadKey();
        }
    }
}
