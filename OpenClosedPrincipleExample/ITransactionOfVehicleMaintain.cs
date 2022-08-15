using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipleExample
{
    public interface ITransactionOfVehicleMaintain
    {
        void PerformTransactionType(Car car);
    }
}
