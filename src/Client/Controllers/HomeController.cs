using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using Server;

namespace Client.Controllers
{
    public class HomeController : BaseController
    {
        public ViewResult Index()
        {
            var model = new BaseModel();
            return View(model);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public ViewResult Index(ContactModel model)
        {

            var contactRequest = new ContactRequest();
            contactRequest.Ad = model.Ad;
            contactRequest.Telefon = model.Telefon;
            contactRequest.Mesaj = model.Mesaj;
            contactRequest.IP = Request.UserHostName;
            try
            {
                SendMail("info@setcrm.com", "info@setcrm.com", contactRequest.Email, "SetCRM--Sizi Arayalım ",
                "<stong>Ad :</stong>" + contactRequest.Ad + "  <br/> " +
                "<stong>Telefon :</stong>" + contactRequest.Telefon + " <br/> " +
                "<stong>Arama İsteği Zamanı :</stong>" + contactRequest.Mesaj + " <br/> " +
                "<stong>IP :</stong>" + contactRequest.IP + " ");
                ViewBag.message = "Mail Başarıyla İletilmiştir.Teşekkürler.";

                model.Ad = "";
                model.Telefon = "";
                model.Mesaj = "";
            }
            catch (Exception)
            {

                ViewBag.message = "Mail Gönderiminde Hata Oluştu Lütfen Daha Sonra Tekrar Deneyiniz.";

            }

            return View(model);
        }
        public static void SendMail(string kimden, string kime, string gonderilenAdSoyad, string konu, string icerik)
        {

            MailMessage message = new MailMessage();

            message.From = new MailAddress(kimden);

            message.To.Add(new MailAddress(kime, gonderilenAdSoyad));

            message.Subject = konu;

            message.Body = icerik;

            message.IsBodyHtml = true;

            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com");

            smtp.UseDefaultCredentials = false;

            System.Net.NetworkCredential ncredential = new System.Net.NetworkCredential("info@setcrm.com", "");

            smtp.Credentials = ncredential;

            smtp.EnableSsl = true;

            smtp.Port = 587;

            smtp.Send(message);
        }
    }
}