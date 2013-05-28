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
        public string username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100,MinimumLength=6)]
        public string passwordhash { get; set; }

    }
}