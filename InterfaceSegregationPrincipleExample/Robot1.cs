using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincipleExample
{
    public class Robot1 : ICook, IClean
    {
        public void Clean()
        {
            Console.WriteLine("Cleaning...");
        }

        public void Cook()
        {
            Console.WriteLine("Cooking...");
        }
    }
}
