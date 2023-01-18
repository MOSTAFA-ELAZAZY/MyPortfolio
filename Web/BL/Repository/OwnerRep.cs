using Infrastructure;
using Microsoft.AspNetCore.Hosting;
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
        private readonly ICacheService _cacheService;
        private readonly IWebHostEnvironment _appEnvironment;

        public OwnerRep(DataContext ApplicationDbCOntext, ICacheService cacheService,IWebHostEnvironment appEnvironment)
        {
            this._ApplicationDbCOntext = ApplicationDbCOntext;
            this._appEnvironment = appEnvironment;
            this._cacheService = cacheService;
        }

        public Owner Get()
        {
            var data = _ApplicationDbCOntext.Owner.FirstOrDefault();
            //_cacheService.SetData(data.FullName, data.Avatar, DateTimeOffset.Now.AddMinutes(5.0));
            _cacheService.SaveData(_appEnvironment, data.FullName, data.Avatar);
            return data;
        }
    }
}
