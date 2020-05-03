using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cafe_Manager.Areas.Admin.Models
{
    public class LoginModels
    {
        [Required(ErrorMessage ="Again enter username")]
        public string UserName { set; get; }

        [Required(ErrorMessage = "Again enter password")]
        public string PassWord { set; get; }

        public bool RememberMe { set; get; }
    }
}