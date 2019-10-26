
using MediatorPattern.Interfaces;

namespace MediatorPattern.Colleagues
{
    public class BaseColleague
    {
        // The Base Component provides the basic functionality of storing a
        // mediator's instance inside component objects.
        protected IMediator IMediator;
            
        public BaseColleague(IMediator mediator = null)
        {
            this.IMediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this.IMediator = mediator;
        }
    }
}
