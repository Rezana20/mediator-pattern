using System;
using System.Reflection.Emit;
using System.Security.Principal;
using MediatorPattern.Colleagues;
using MediatorPattern.Interfaces;

namespace MediatorPattern.Mediators
{
    // Concrete Mediators implement cooperative behavior by coordinating several
    // components.
    public class ConcreteMediator : IMediator
    {
        //register each colleague
        private ColleagueOne ColleagueOne;
        private ColleagueTwo ColleagueTwo;

        public ConcreteMediator(ColleagueOne colleagueOne, ColleagueTwo colleagueTwo)
        {
            this.ColleagueOne = colleagueOne;
            this.ColleagueOne.SetMediator(this);
            this.ColleagueTwo = colleagueTwo;
            this.ColleagueTwo.SetMediator(this);
        }


        public void Notify(object sender, string ev)
        {
            if (ev.Equals("A"))
            {
                
                Console.WriteLine("Mediator reacts on A and triggers the following operations:");
                this.ColleagueTwo.DoC();
            }

            if (ev.Equals("D"))
            {
                Console.WriteLine("Mediator reacts on D and triggers the following operations:");
                this.ColleagueOne.DoB();
                this.ColleagueTwo.DoC();

            }
        }
    }
}