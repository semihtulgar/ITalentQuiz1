using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincipleExample
{
    public class MeetParty : IEvent
    {
        public void PrepareEvent()
        {
            Console.WriteLine("Tanışma Partisi Düzenleniyor...");
        }
    }
}
