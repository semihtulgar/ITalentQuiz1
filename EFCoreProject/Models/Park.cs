﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject.Models
{
    public class Park
    {
        public int Id { get; set; }
        public string ParkName { get; set; }
        public ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}
