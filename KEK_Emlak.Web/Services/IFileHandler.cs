﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KEK_Emlak.Web.Models
{
    public interface IFileHandler
    {
        string ResizeAndUploadImage(string foldername, IFormFile file);
        string UploadFile(string foldername, IFormFile file);
        void DeleteFile(string foldername);
        string UpdateFile(string property, string foldername, IFormFile file);
        
    }
}
