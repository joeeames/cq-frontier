using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CQ.Frontier.Web.Models
{
    public class UserModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(100)]
        [Display(Name = "Email Address")]
        public string username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100,MinimumLength=1)]
        [Display(Name="Password")]
        public string passwordhash { get; set; }

    }
}