using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipleExample
{
    public class DoTransaction
    {
        ITransactionOfVehicleMaintain _transactionType;

        public DoTransaction(ITransactionOfVehicleMaintain transactionType)
        {
            _transactionType = transactionType;
        }

        public void PerformTransaction(Car car)
        {
            _transactionType.PerformTransactionType(car);
        }

    }
}
