using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Caching;
using System.Threading.Tasks;
using Web.BL.Interface;

namespace Web.BL.Logic
{
    public class CacheService : ICacheService
    {
        ObjectCache _memoryCache = MemoryCache.Default;

        //public T GetData<T>(string key)
        //{
        //    try
        //    {
        //        T item = (T)_memoryCache.Get(key);
        //        return item;
        //    }
        //    catch (Exception e)
        //    {
        //        throw;
        //    }
        //}
        //public bool SetData<T>(string key, T value, DateTimeOffset expirationTime)
        //{
        //    bool res = true;
        //    try
        //    {
        //        if (!string.IsNullOrEmpty(key))
        //        {
        //            _memoryCache.Set(key, value, expirationTime);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw;
        //    }
        //    return res;
        //}
        //public object RemoveData(string key)
        //{
        //    try
        //    {
        //        if (!string.IsNullOrEmpty(key))
        //        {
        //            return _memoryCache.Remove(key);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw;
        //    }
        //    return false;
        //}

        public string SaveData(IWebHostEnvironment webHostEnvironment , string FileName_, byte[] FileData_)
        {
            string Url = "";
            BinaryWriter writer = null;

            string pathToSave = webHostEnvironment.WebRootPath + "\\img\\" + FileName_;
            if (!File.Exists(pathToSave))
            {
                writer = new BinaryWriter(File.OpenWrite(pathToSave));
                writer.Write(FileData_);
                writer.Close();
            }

            return Url;
        }
    }
}
