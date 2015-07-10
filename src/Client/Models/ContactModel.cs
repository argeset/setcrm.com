using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client.Models
{
    public class ContactModel : BaseModel
    {
        public string Ad { get; set; }
        public string Firma { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Mesaj { get; set; }
    }
}