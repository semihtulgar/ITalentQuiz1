using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string RegistrationPlate { get; set; }
        public ICollection<Park> Parks { get; set; } = new List<Park>();
        public Brand? Brand { get; set; }
        public int? BrandId { get; set; }
    }
}
