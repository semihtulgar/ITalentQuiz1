using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Cake
    {
        public List<string> Material { get; set; }

        public void PrepareCake(List<string> materials)
        {
            Console.WriteLine("Kek Hazırlanıyor...");
            MixTheMaterial();
            Bake();
        }

        private void MixTheMaterial()
        {
            Console.WriteLine("Malzemeler Karıştırılıyor...");
        }

        private void Bake()
        {
            Console.WriteLine("Fırında pişiriliyor...");
            Console.WriteLine("Afiyet Olsun");
        }


    }
}
