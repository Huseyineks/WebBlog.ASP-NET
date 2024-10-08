﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBlog.BusinessLogicLayer.Model.DTOs
{
    public class ArticleDTO
    {
        public int ID { get; set; }

        public IFormFile? Image { get; set; }


        public string? Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
