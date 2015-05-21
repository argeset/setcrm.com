using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Client.Controllers
{
    public class HomeController : BaseController
    {
        public ViewResult Index()
        {
            var model = new BaseModel();
            return View(model);
        }
    }
}