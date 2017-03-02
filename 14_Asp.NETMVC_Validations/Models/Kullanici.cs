using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _14_Asp.NETMVC_Validations.Models
{
    //data annotations
    public class Kullanici
    {

        [DisplayName("Adınız")]
        public string Ad { get; set; }

        [DisplayName("Soyadınız")]
        public string Soyad { get; set; }

        [DisplayName("Yaş"),
        Range(1,100,ErrorMessage = "Lütfen {1}-{2} arasında bir {0} değeri giriniz!")]
        public int Yas { get; set; }

        [DisplayName("Kullanıcı Adı"),
            Required(ErrorMessage = "Lütfen bir {0} giriniz"),
            MinLength(5,ErrorMessage = "{0} en az {1} karakter olmalıdır!"),
            MaxLength(25, ErrorMessage = " {0} en fazla {1} karakter olabilir!")]
        public string KullaniciAdi { get; set; }

        [DisplayName("Şifre"), 
            Required(ErrorMessage = "Lutfen bir {0} giriniz"),
            MinLength(6,ErrorMessage = "{0} en az {1} karakter olmalıdır!"),
            MaxLength(16, ErrorMessage = "{0} en fazla {1} karakter olabilir!"),
            DataType(DataType.Password)]
        public string Sifre { get; set; }

        [DisplayName("Şifre (Tekrar)"),
           Required(ErrorMessage = "Lutfen bir {0} giriniz"), 
           MinLength(6, ErrorMessage = "{0} en az {1} karakter olmalıdır!"), 
           MaxLength(16, ErrorMessage = "{0} en fazla {1} karakter olabilir!"), 
           DataType(DataType.Password),Compare(nameof(Sifre),ErrorMessage = "{0} ile {1} uyuşmuyor !")]
        public string Sifre2 { get; set; }

        [DisplayName("E-Posta"), 
            Required(ErrorMessage = "Lütfen geçerli bir {0} giriniz"),
            MaxLength(60,ErrorMessage = "{0} max {1} karakter olmalıdır!"),
            EmailAddress(ErrorMessage = "Lütfen geçerli bir {0} adresi giriniz!")]
        public string Eposta { get; set; }

        [DisplayName("E-Posta (Tekrar)"), 
            Required(ErrorMessage = "Lütfen geçerli bir {0} giriniz"), 
            MaxLength(60, ErrorMessage = "{0} max {1} karakter olmalıdır!"), 
            EmailAddress(ErrorMessage = "Lütfen geçerli bir {0} giriniz!"),
            Compare(nameof(Eposta),ErrorMessage = "{0} ile {1} uyuşmuyor !")]
        public string Eposta2 { get; set; }

        [DisplayName("Tuttuğunuz Takım"),
            MaxLength(25,ErrorMessage = "Spor takımı max {1} karakter olabilir !")]
        public string Takim { get; set; }


    }
}