using System;

namespace MediatorPattern.Colleagues
{
    // Concrete Components implement various functionality. They don't depend on
    // other components. They also don't depend on any concrete mediator
    // classes.
    public class ColleagueOne: BaseColleague
    {
        public void DoA()
        {
            Console.WriteLine("ColleagueOne does A");
            this.IMediator.Notify(this, "A");
        }

        public void DoB()
        {
            Console.WriteLine("ColleagueOne does B");
            this.IMediator.Notify(this,"B");
        }

    }
}