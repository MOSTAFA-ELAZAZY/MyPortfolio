using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.BL.Interface;
using Web.DAL.Entities;

namespace Web.BL.Repository
{
    public class OwnerRep : IOwner
    {

        private readonly DataContext _ApplicationDbCOntext;

        public OwnerRep(DataContext ApplicationDbCOntext)
        {
            this._ApplicationDbCOntext = ApplicationDbCOntext;
        }

        public Owner Get()
        {
            var data = _ApplicationDbCOntext.Owner.FirstOrDefault();
            return data;
        }
    }
}
