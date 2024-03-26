using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBlog.Entitiy.Entities;

namespace WebBlog.BusinessLogicLayer.Model.DTOs
{
    public class DetailsDTO
    {
        public Article Article {  get; set; }
        public CommentDTO? comment { get; set; }
    }
}
