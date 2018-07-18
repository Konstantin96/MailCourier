using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Express_mail.lib.Modul
{
    public enum DocumentType
    {
        Message, Package, Government
    }
    public class BuisnesMail:Express
    {
        public DocumentType DocumentType { get; set; }
    }
}
