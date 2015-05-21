using Client.Models;
using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Client.Controllers
{
    public class ContactController : BaseController
    {
        [HttpGet]
        public ViewResult Index()
        {
            var model = new ContactModel();
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ViewResult Index(ContactModel model)
        {

            var contactService = new ContactService();

            var contactRequest = new ContactRequest();
            contactRequest.Ad = model.Ad;
            contactRequest.Email = model.Email;
            contactRequest.Mesaj = model.Mesaj;
            contactRequest.IP = Request.UserHostName;

            var contactResponse = contactService.AddMessage(contactRequest);
            if (contactResponse.IsOk)
            {
                //
            }

            return View(model);
        }
    }
}