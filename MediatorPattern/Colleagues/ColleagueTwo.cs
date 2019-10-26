using System;

namespace MediatorPattern.Colleagues
{
    public class ColleagueTwo: BaseColleague
    {
        public void DoC()
        {
            Console.WriteLine("ColleagueTwo does C");
            this.IMediator.Notify(this,"C");
        
        }

        public void DoD()
        {
            Console.WriteLine("ColleagueTwo does D");
            this.IMediator.Notify(this,"D");
        }
        
    }
}