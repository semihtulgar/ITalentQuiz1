using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincipleExample
{
    public class WelcomeToSummerParty : IEvent
    {
        public void PrepareEvent()
        {
            Console.WriteLine("Yaza Merhaba Partisi Hazırlanıyor...");
        }

    }
}
