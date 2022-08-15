using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityExample
{
    public class CarManager
    {
        public void SellCar(Car car)
        {
            Console.WriteLine("Araba satıldı.");
        }

        public void RentCar(Car car)
        {
            Console.WriteLine("Araba kiralandı.");
        }
    }
}
