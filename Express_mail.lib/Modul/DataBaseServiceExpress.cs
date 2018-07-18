using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Express_mail.lib.Modul
{
    public class DataBaseServiceExpress
    {
        public void AddCourierWayBill(ExpressMail e)
        {
            try
            {
                using (var db = new LiteDatabase(@"CourierWaybill.db"))
                {
                    LiteCollection<ExpressMail> collection = db.GetCollection<ExpressMail>("Express");
                    collection.Insert(e);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AddCourierWayBill(BuisnesMail b)
        {
            try
            {
                using (var db = new LiteDatabase(@"CourierWaybill.db"))
                {
                    LiteCollection<BuisnesMail> collection = db.GetCollection<BuisnesMail>("Business");
                    collection.Insert(b);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AddCourierWayBill(BlizhMail b)
        {
            try
            {
                using (var db = new LiteDatabase(@"CourierWaybill.db"))
                {
                    LiteCollection<BlizhMail> collection = db.GetCollection<BlizhMail>("Blitz");
                    collection.Insert(b);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Метод возвращет Blitz по его ID
        /// </summary>
        /// <param name="e">ID курьерской накладной</param>
        /// <returns>Найденная курьерская наладная</returns>
        public BlizhMail GetBlitzKNById(string e)
        {
            BlizhMail blitzKN = null;
            try
            {
                using (var db = new LiteDatabase(@"CourierWaybill.db"))
                {
                    LiteCollection<BlizhMail> collection = db.GetCollection<BlizhMail>("Blitz");
                    blitzKN = (BlizhMail)collection.Find(d => d.DeliveryNoteId == e);
                }
            }
            catch (Exception)
            {
            }

            return blitzKN;
        }

        /// <summary>
        /// Метод возвращет Business по его ID
        /// </summary>
        /// <param name="e">ID курьерской накладной</param>
        /// <returns>Найденная курьерская наладная</returns>
        public BuisnesMail GetBusinessKNyId(string e)
        {
            BuisnesMail businessKN = null;
            try
            {
                using (var db = new LiteDatabase(@"CourierWaybill.db"))
                {
                    LiteCollection<BuisnesMail> collection = db.GetCollection<BuisnesMail>("Business");
                    businessKN = (BuisnesMail)collection.Find(d => d.DeliveryNoteId == e);
                }
            }
            catch (Exception)
            {
            }

            return businessKN;
        }

        /// <summary>
        /// Метод возвращет Express по его ID
        /// </summary>
        /// <param name="e">ID курьерской накладной</param>
        /// <returns>Найденная курьерская наладная</returns>
        public ExpressMail GetExpressKNyId(string e)
        {
            ExpressMail expressKN = null;
            try
            {
                using (var db = new LiteDatabase(@"CourierWaybill.db"))
                {
                    LiteCollection<ExpressMail> collection = db.GetCollection<ExpressMail>("Business");
                    expressKN = (ExpressMail)collection.Find(d => d.DeliveryNoteId == e);
                }
            }
            catch (Exception)
            {
            }

            return expressKN;
        }
    }
}
