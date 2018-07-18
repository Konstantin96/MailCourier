using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Express_mail.lib.Modul
{
    public abstract class Express
    {
        public Express() { }
        public string DeliveryNoteId { get; set; }
        public Address senderAddress { get; set; }
        public Address receiverAddress { get; set; }
        public string senderFIO { get; set; }
        public string receiverFIO { get; set; }
        public string senderPhone { get; set; }
        public string receiverPhone { get; set; }
        /// <summary>
        /// Информация о получателе и отправителе
        /// </summary>
        public virtual void GetInfo()
        {
            Console.WriteLine(" ID: {0}", DeliveryNoteId);
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("From: {0}", senderFIO);
            Console.WriteLine("Address: {0}", senderAddress);
            Console.WriteLine("Phone: {0}", senderPhone);
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("To: {0}", receiverFIO);
            Console.WriteLine("Address: {0}", receiverAddress);
            Console.WriteLine("Phone: {0}", receiverPhone);

        }

    }
}
