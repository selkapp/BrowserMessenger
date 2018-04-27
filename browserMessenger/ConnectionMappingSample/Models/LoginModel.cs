using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace browserMessenger.Models {
    
    public class LoginModel {

        [Required]
        public string Nick { get; set; }
    }
}