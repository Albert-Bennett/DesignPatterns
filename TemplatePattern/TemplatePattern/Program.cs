using System;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass template = new SubClass();
            template.TemplateMethod();

            Console.ReadKey();
        }
    }
}
