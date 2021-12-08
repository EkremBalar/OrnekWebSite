﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrnekWebSite.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Adınız")]
        public string Name { get; set; }
        [Required]
        [DisplayName(" Soyadınız")]
        public string Surname { get; set; }
        [Required]
        [DisplayName("Kullanıcı Adınız")]
        public string Username { get; set; }

        [Required]
        [DisplayName("Email")]
        [EmailAddress(ErrorMessage ="Geçersiz Email Adresi")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage  = "Şifre Ayni Değil")]
        [DisplayName("Şfre Tekrar")]
        public string RePassword { get; set; }
    }
}