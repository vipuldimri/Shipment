﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Carrier
    {
        public int carrier_id { get; set; }
        public string carrier_name { get; set; }
        public string carrier_mode { get; set; }
    }
}
