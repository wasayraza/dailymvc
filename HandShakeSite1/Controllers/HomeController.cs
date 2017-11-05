using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandShakeSite1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PostTweet(string txtTweet)
        {
            var httpclient = new System.Net.Http.HttpClient();
            var api = new api.Controllers.FacebookController();
            var data = api.Get(1);
            Session["tweet"] = data.First();
            return RedirectToAction("Index", "FaceBook");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}