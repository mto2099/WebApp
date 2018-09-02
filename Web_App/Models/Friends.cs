using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_App.Models
{
    public class Friends
    {
        [Key]
        public string RequestUserID { get; set; }
        public string TargetUserID { get; set; }
        
    }
}