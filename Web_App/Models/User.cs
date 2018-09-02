using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_App.Models
{
    public class User
    {   

        
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        
        public string Location { get; set; }

        public bool SetLibraryPublic { get; set; }
    }
}