using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ContactRequest
    {
        public string Ad { get; set; }
        public string Firma { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Mesaj { get; set; }
        public string IP { get; set; }
    }
}
