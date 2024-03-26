using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBlog.BusinessLogicLayer.Model.DTOs
{
    public class RegisterDTO
    {
        public string firstName { get; set; }

        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public string confirmPassword { get; set; }
    }
}
