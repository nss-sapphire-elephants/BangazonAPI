﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BangazonSprint.Models
{
    public class Computer
    {
        public DateTime PurchaseDate { get; set; }
        public DateTime DecomissionDate { get; set; }
        public string Make { get; set; }
        public string Manufacturer { get; set; }
    }
}
