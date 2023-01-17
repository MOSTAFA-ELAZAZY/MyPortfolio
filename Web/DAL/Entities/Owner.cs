using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.DAL.Entities
{
    public class Owner : EntityBase
    {
        [Required, MaxLength(250)]
        public string FullName { get; set; }
        [Required, MaxLength(250)]
        public string Profil { get; set; }
        public byte[] Avatar { get; set; }
        [Required, MaxLength(100)]
        public string Street { get; set; }
        [Required, MaxLength(50)]
        public string City { get; set; }
        public int Number { get; set; }

    }
}
