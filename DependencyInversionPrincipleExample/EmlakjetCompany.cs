using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincipleExample
{
    internal class EmlakjetCompany : ICompany
    {
        IEvent _eventType;

        public EmlakjetCompany(IEvent eventType)
        {
            _eventType = eventType;
        }

        public void PrepareEvent()
        {
            _eventType.PrepareEvent();
        }
    }
}
