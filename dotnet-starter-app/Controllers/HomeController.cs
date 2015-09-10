using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;

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
            //Ask for environment variables
            string vcap = Environment.GetEnvironmentVariable("VCAP_SERVICES");
            //If we're on localhost, this will be null
            if (vcap != null)
            {
                JObject services = Newtonsoft.Json.Linq.JObject.Parse(vcap);
                ViewBag.json = services;
            }
            return View();
        }

        // GET: /Home/UseService/

        public ActionResult UseService()
        {
            return View();
        }

        
    }
}
