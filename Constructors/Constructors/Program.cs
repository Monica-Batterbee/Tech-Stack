using System;
namespace ConstructorProgram
{
    class ConstructureClass
    {
        public string name, location;

        public ConstructureClass()
        {
            name = "Alex Len";
            location = "San Francisco";
        }

        public ConstructureClass(string a, string b)
        {
            name = a;
            location = b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConstructureClass className = new ConstructureClass();
            Console.WriteLine(className.name);
            Console.WriteLine(className.location);
        }
    }
}