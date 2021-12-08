using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrnekWebSite.Models
{
    public class ChangePasswordModel
    {
        [Required]
        [DisplayName("Eski Şifre")]
        public string OldPassword { get; set; }

        [Required]
        [DisplayName("Yeni Şifre")]

        public string NewPassword { get; set; }


        [Required]
        [DisplayName("Yeni Şifre Tekrar")]
        [Compare("NewPassword",ErrorMessage ="Şifreler Aynı Değil!")]
        public string ConNewPassword { get; set; }
    }
}