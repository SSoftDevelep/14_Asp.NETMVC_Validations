using _14_Asp.NETMVC_Validations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _14_Asp.NETMVC_Validations.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new Kullanici());
        }

        [HttpPost]
        public ActionResult Index(Kullanici model)
        {
            if (model.KullaniciAdi=="seyido")
            {
                //Veritabanindan kullanıcı adı kullanılıyor mu kontrolu yaptınız varsayalım..
                ModelState.AddModelError("", "Bu kullanıcı adı kullanılıyor");
            }
            return View(model);
        }
    }
}