using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Express_mail.lib.Modul
{
    public enum RateType
    {
        DoorDoor, DoorStock, StockDoor
    }
    public class BlizhMail : Express
    {
        public RateType RateType { get; set; }
    }
}
