using System.Web.Mvc;
using Client.Models;

namespace Client.Controllers
{
    public class PropertyController:BaseController
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }
         
    }
}