using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    public class CarManager : ICarDal
    {
        public void GetAllCars()
        {
            Console.WriteLine("Bütün arabalar listelendi");
        }

        public void GetCar()
        {
            Console.WriteLine("Araba listelendi");
        }
    }
}
