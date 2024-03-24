using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBlog.Entitiy.Entities
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        public string AdminName { get; set; }

        public string AdminLastName { get; set; }




    }
}
