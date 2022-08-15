using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincipleExample
{
    public interface IEvent
    {
        void PrepareEvent();
    }
}
