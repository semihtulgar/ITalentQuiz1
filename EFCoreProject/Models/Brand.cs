using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }
    }
}
