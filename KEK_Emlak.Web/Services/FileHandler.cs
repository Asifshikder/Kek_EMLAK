﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KEK_Emlak.Web.Models
{
    public class FileHandler : IFileHandler
    {
        private IWebHostEnvironment webHost;

        public FileHandler(IWebHostEnvironment webHost)
        {
            this.webHost = webHost;
        }

        public void DeleteFile(string foldername)
        {
            string dbpath = foldername.Replace("~/", "").ToString();
            string uppath = dbpath.Replace("/", "\\").ToString();
            string fullpath = webHost.WebRootPath + "\\" + uppath;
            System.IO.File.Delete(fullpath);
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public string ResizeAndUploadImage(string foldername, IFormFile file)
        {
            throw new NotImplementedException();
        }

        public string UpdateFile(string property, string foldername, IFormFile file)
        {
            if (property != null)
            {
                string dbpath = property.Replace("~/", "").ToString();
                string uppath = dbpath.Replace("/", "\\").ToString();
                string fullpath = webHost.WebRootPath + "\\" + uppath;
                System.IO.File.Delete(fullpath);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

            Guid nameguid = Guid.NewGuid();
            string webrootpath = webHost.WebRootPath;
            string filename = nameguid.ToString();
            string extension = Path.GetExtension(file.FileName);
            filename = filename + extension;
            string path = Path.Combine(webrootpath, foldername, filename);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
            string pathName = Path.Combine(foldername, filename);
            string fileUrl = "~/" + foldername + "/" + filename;
            return fileUrl;
        }

        public string UploadFile(string foldername, IFormFile file)
        {
            Guid nameguid = Guid.NewGuid();
            string webrootpath = webHost.WebRootPath;
            string filename = nameguid.ToString();
            string extension = Path.GetExtension(file.FileName);
            filename = filename + extension;
            string path = Path.Combine(webrootpath, foldername, filename);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
            string pathName = Path.Combine(foldername, filename);
            string fileUrl = "~/" + foldername + "/" + filename;
            return fileUrl;
        }
    }
}
