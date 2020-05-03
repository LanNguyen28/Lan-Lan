using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cafe_Manager
{
    [Serializable]
    public class UserLogin
    {
        public long UserID { set; get; }
        public string UserName { set; get; }
        public string PassWord { set; get; }
    }
}