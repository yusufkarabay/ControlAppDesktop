using DataAccess.Abstract;
using DataAccess.Database;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Concrete
{
    public class GuestCardDal : SqlService, IRepository<GuestCard>
    {
        static GuestCardDal guestCardDal;
        SqlService sqlService;
        public GuestCardDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }
        public static GuestCardDal GetInstance()
        {
            if (guestCardDal == null)
            {
                guestCardDal = new GuestCardDal();
            }
            return guestCardDal;
        }
        public string Add(GuestCard entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("GuestCardDelivery", new SqlParameter("@guestcardno", entity.GuestCardNo),
                    new SqlParameter("@receiveremployee", entity.ReceiverEmployee), new SqlParameter("@deliveriyemployee", entity.DeliveryEmployee),
                    new SqlParameter("@deliverydate", entity.DeliveryDate));
                if (isSuccess)
                {
                    return entity.GuestCardNo + " Numaralı Misafir Kartı Teslim Edilmişitir";
                }

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            return result;
        }
        public string Delete(Guid id)
        {

            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("GuestCardReturnDelivery", new SqlParameter("@guestcardid", id));
                if (isSuccess)
                {
                    result = "Misafir Kartı Başarı İle Teslim Alındı";
                }
                else
                {
                    result = msg;
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            return result;
        }
        public GuestCard Get(Guid id)
        {
            throw new NotImplementedException();
        }
        public List<GuestCard> GetAll()
        {
            List<GuestCard> guestcards = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2("GuestCardList");
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    guestcards = new List<GuestCard>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        guestcards.Add(new GuestCard(
                       Guid.Parse(dataRow["GUESTCARDID"].ToString()),
                       dataRow["GUESTCARDNO"].ToString(),
                       dataRow["RECEIVEREMPLOYEE"].ToString(),
                       $"{dataRow["RECEIVERPERSON_NAME"].ToString()} {dataRow["RECEIVERPERSON_SURNAME"].ToString()}",
                       dataRow["DELIVERYEMPLOYEE"].ToString(),
                        $"{dataRow["DELIVERYPERSON_NAME"].ToString()} {dataRow["DELIVERYPERSON_SURNAME"].ToString()}",
                       DateTime.Parse(dataRow["DELIVERYDATE"].ToString())));

                    }
                }
            }
            catch (Exception ex) { }
            finally { }

            return guestcards;
        }
        public List<GuestCard> GuestCardByDeliveryEmployee(string procuderName, string deliveryEmployeeName)
        {
            List<GuestCard> guestcards = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@deliveryemployee", deliveryEmployeeName));

                if (dt.Rows.Count > 0)
                {
                    guestcards = new List<GuestCard>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        guestcards.Add(new GuestCard(
                         Guid.Parse(dataRow["GUESTCARDID"].ToString()),
                         dataRow["GUESTCARDNO"].ToString(),
                         dataRow["RECEIVEREMPLOYEE"].ToString(),
                         $"{dataRow["RECEIVERPERSON_NAME"].ToString()} {dataRow["RECEIVERPERSON_SURNAME"].ToString()}",
                         dataRow["DELIVERYEMPLOYEE"].ToString(),
                          $"{dataRow["DELIVERYPERSON_NAME"].ToString()} {dataRow["DELIVERYPERSON_SURNAME"].ToString()}",
                         DateTime.Parse(dataRow["DELIVERYDATE"].ToString())));


                    }
                }
                else guestcards = null;
            }

            catch (Exception ex) { }
            finally { }

            return guestcards;
        }
        public List<GuestCard> GuestCardByReceiverEmployee(string procuderName, string receiverEmployeeName)
        {
            List<GuestCard> guestcards = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@receiveremployee", receiverEmployeeName));

                if (dt.Rows.Count > 0)
                {
                    guestcards = new List<GuestCard>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        guestcards.Add(new GuestCard(
                         Guid.Parse(dataRow["GUESTCARDID"].ToString()),
                         dataRow["GUESTCARDNO"].ToString(),
                         dataRow["RECEIVEREMPLOYEE"].ToString(),
                         $"{dataRow["RECEIVERPERSON_NAME"].ToString()} {dataRow["RECEIVERPERSON_SURNAME"].ToString()}",
                         dataRow["DELIVERYEMPLOYEE"].ToString(),
                          $"{dataRow["DELIVERYPERSON_NAME"].ToString()} {dataRow["DELIVERYPERSON_SURNAME"].ToString()}",
                         DateTime.Parse(dataRow["DELIVERYDATE"].ToString())));


                    }
                }
                else guestcards = null;
            }

            catch (Exception ex) { }
            finally { }

            return guestcards;
        }
        public List<GuestCard> GuestCardByGuestCardNo(string procuderName, string guestCardNo)
        {
            List<GuestCard> guestcards = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@guestcardno", guestCardNo));

                if (dt.Rows.Count > 0)
                {
                    guestcards = new List<GuestCard>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        guestcards.Add(new GuestCard(
                         Guid.Parse(dataRow["GUESTCARDID"].ToString()),
                         dataRow["GUESTCARDNO"].ToString(),
                         dataRow["RECEIVEREMPLOYEE"].ToString(),
                         $"{dataRow["RECEIVERPERSON_NAME"].ToString()} {dataRow["RECEIVERPERSON_SURNAME"].ToString()}",
                         dataRow["DELIVERYEMPLOYEE"].ToString(),
                          $"{dataRow["DELIVERYPERSON_NAME"].ToString()} {dataRow["DELIVERYPERSON_SURNAME"].ToString()}",
                         DateTime.Parse(dataRow["DELIVERYDATE"].ToString())));


                    }
                }
                else guestcards = null;
            }

            catch (Exception ex) { }
            finally { }

            return guestcards;
        }

        public string Update(GuestCard entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(GuestCard entity)
        {
            throw new NotImplementedException();
        }
    }
}
