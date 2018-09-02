using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_App.Models
{
    public class Library
    {   
        [Key]
        public int LibID { get; set; }
        public string BookName { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public string Status { get; set; }
        public string ISBN { get; set; }
        public string reviews{ get; set; }

    }
}