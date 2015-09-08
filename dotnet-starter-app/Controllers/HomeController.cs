using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dotnet_starter_app.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        // GET: /Home/AddService/

        public ActionResult AddService()
        {
            return View();
        }

        // GET: /Home/UseService/

        public ActionResult UseService()
        {
            return View();
        }

        
    }
}
