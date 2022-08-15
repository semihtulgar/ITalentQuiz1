using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincipleExample
{
    internal class Robot2 : IClean
    {
        public void Clean()
        {
            Console.WriteLine("Cleaning...");
        }
    }
}
