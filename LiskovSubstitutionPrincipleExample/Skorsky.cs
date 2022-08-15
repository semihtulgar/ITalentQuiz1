using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincipleExample
{
    public class Skorsky : ITransport, IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Ateş ediliyor.");
        }

        public void CarryTheTeam()
        {
            Console.WriteLine("Personel taşınıyor.");
        }
    }
}
