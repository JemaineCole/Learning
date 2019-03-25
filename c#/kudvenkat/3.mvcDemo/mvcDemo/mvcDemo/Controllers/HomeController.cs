using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcDemo.Controllers
{
    //http://localhost/mvcDemo/

    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from MVC Application";
        }

        public string getDetails()
        {
            return "getDetails() invoked";
        }

    }
}