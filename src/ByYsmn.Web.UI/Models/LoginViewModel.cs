﻿using System.ComponentModel.DataAnnotations;

namespace ByYsmn.Web.UI.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Parola")]
        [StringLength(20, ErrorMessage = "Lutfen {0} en az {2} karakter olmali en uzun {1} karakter olmali", MinimumLength = 6)]
        public string Password { get; set; }
    }
}
