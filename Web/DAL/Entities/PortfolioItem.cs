﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class PortfolioItem : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] ImageUrl { get; set; }

    }
}