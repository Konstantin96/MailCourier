using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Express_mail.lib.Modul
{
    public enum TypeGood
    {
        Sklad,dveri
    }
    public enum TypeDocument
    {
        Hrupkoe,ZashitaOtVlagi,NelzyaRaskachivat
    }
    public class TypeOfGoods
    {
        public TypeGood TypeGood { get; set; }
        public TypeDocument TypeDocument { get; set; }
    }
}
