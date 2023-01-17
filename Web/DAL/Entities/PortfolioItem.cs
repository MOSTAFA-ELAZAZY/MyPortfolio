using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.DAL.Entities
{

    public class PortfolioItem : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] ImageUrl { get; set; }

    }
}
