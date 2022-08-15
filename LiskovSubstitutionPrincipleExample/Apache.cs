using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincipleExample
{
    public class Apache : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Ateş ediliyor");
        }
    }
}
