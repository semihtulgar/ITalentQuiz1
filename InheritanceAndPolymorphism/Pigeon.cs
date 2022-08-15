using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class Pigeon : Bird
    {
        public override void Chirping()
        {
            Console.WriteLine("Gak gak gak...");
        }
    }
}
