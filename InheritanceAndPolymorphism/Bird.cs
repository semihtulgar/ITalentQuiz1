using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class Bird
    {
        public string Type { get; set; }

        public virtual void Chirping()
        {
            Console.WriteLine("Cik cik cik...");
        }

        public void Fly()
        {
            Console.WriteLine("Flying.......");
        }
    }
}
