using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincipleExample
{
    internal class ILABCompany : ICompany
    {
        IEvent _eventType;

        public ILABCompany(IEvent eventType)
        {
            _eventType = eventType;
        }
        
        public void PrepareEvent()
        {
            _eventType.PrepareEvent();
        }

    }
}
