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
                ViewBag.Json = services;
            }
            else {
                ViewBag.Json = "{\"Id\":\"123\",\"filesystem-1.0\":\"hi\",\"DateOfRegistration\":\"2012-10-21T00:00:00+05:30\",\"Status\":0}";
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
