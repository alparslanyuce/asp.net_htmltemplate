using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banzhow.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            //veritabanından bütün blog bilgileri al ve view üzerine gönder.
            // kendisine gelen blog bilgilerini dinamik içerik üreten View yapısı bunu statik Html'e çevirir.
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }
    }
}