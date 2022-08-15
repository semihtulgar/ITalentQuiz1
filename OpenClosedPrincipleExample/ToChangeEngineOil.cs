using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipleExample
{
    public class ToChangeEngineOil : ITransactionOfVehicleMaintain
    {
        public void PerformTransactionType(Car car)
        {
            Console.WriteLine($"{car.CarId} numaralı aracın motor yağı değiştirildi.");
        }
    }
}
