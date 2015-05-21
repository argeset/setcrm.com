using System.Web.Mvc;

namespace Client.Controllers
{
    public class ContentController:BaseController
    {
        [HttpGet]
        public ViewResult Customers()
        {
            return View();
        }

        [HttpGet]
        public ViewResult PrivacyAgreement()
        {
            return View();
        }

        [HttpGet]
        public ViewResult TermsofUse()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Crm()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Reporting()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Workflow()
        {
            return View();
        }
    }
}