﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abgf.babycheck.frontend.model
{
    public class GarmentType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }

        List<Garment> Garments { get; set; }
    }
}
