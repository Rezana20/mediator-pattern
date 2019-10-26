using System;
using MediatorPattern.Colleagues;
using MediatorPattern.Mediators;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            ColleagueOne component1 = new ColleagueOne();
            ColleagueTwo component2 = new ColleagueTwo();
            new ConcreteMediator(component1, component2);

            Console.WriteLine("Client triggers operation A.");
            component1.DoA();

            Console.WriteLine();

            Console.WriteLine("Client triggers operation D.");
            component2.DoD();
        }
    }
}
