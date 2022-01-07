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
    public class EntranceCardDal : SqlService, IRepository<EntranceCard>
    {
        static EntranceCardDal entranceCardDal;
        SqlService sqlService;

        public EntranceCardDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }
        public string Add(EntranceCard entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("EntranceCardDelivery", new SqlParameter("@entrancecardserino", entity.EntranceCardSeriNo),
                    new SqlParameter("@receiveremployee", entity.ReceiverEmployee), new SqlParameter("@deliveryemployee", entity.DeliveryEmployee),
                    new SqlParameter("@deliverydate", entity.DeliveryDate));
                if (isSuccess)
                {
                    return entity.EntranceCardSeriNo + " Seri Numaralı Giriş Kartı Teslim Edilmişitir";
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
                var (isSuccess, msg) = sqlService.StoreReaderV2("EntranceCardReturnDelivery", new SqlParameter("@entrancecardid", id));
                if (isSuccess)
                {
                    result = "Kart Başarı İle Teslim Alındı";
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

        public EntranceCard Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<EntranceCard> GetAll()
        {
            List<EntranceCard> entranceCards = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2("EntranceCardList");
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    entranceCards = new List<EntranceCard>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        entranceCards.Add(new EntranceCard(
                       Guid.Parse(dataRow["ENTRANCECARDID"].ToString()),
                       dataRow["ENTRANCECARDSERINO"].ToString(),
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

            return entranceCards;
        }

        public List<EntranceCard> EntranceCardByDeliveryEmployee(string procuderName, string deliveryEmployeeName)
        {

            List<EntranceCard> entranceCards = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@deliveryemployee", deliveryEmployeeName));
                if (dt.Rows.Count > 0)
                {
                    entranceCards = new List<EntranceCard>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        entranceCards.Add(new EntranceCard(
                       Guid.Parse(dataRow["ENTRANCECARDID"].ToString()),
                       dataRow["ENTRANCECARDSERINO"].ToString(),
                       dataRow["RECEIVEREMPLOYEE"].ToString(),
                       $"{dataRow["RECEIVERPERSON_NAME"].ToString()} {dataRow["RECEIVERPERSON_SURNAME"].ToString()}",
                       dataRow["DELIVERYEMPLOYEE"].ToString(),
                        $"{dataRow["DELIVERYPERSON_NAME"].ToString()} {dataRow["DELIVERYPERSON_SURNAME"].ToString()}",
                       DateTime.Parse(dataRow["DELIVERYDATE"].ToString())));

                    }
                }
                else entranceCards = null;
            }
            catch (Exception ex) { }
            finally { }

            return entranceCards;
        }
        public List<EntranceCard> EntranceCardByReceiverEmployee(string procuderName, string receiverEmployeeName)
        {
            List<EntranceCard> entranceCards = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@receiveremployee", receiverEmployeeName));
                if (dt.Rows.Count > 0)
                {
                    entranceCards = new List<EntranceCard>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        entranceCards.Add(new EntranceCard(
                       Guid.Parse(dataRow["ENTRANCECARDID"].ToString()),
                       dataRow["ENTRANCECARDSERINO"].ToString(),
                       dataRow["RECEIVEREMPLOYEE"].ToString(),
                       $"{dataRow["RECEIVERPERSON_NAME"].ToString()} {dataRow["RECEIVERPERSON_SURNAME"].ToString()}",
                       dataRow["DELIVERYEMPLOYEE"].ToString(),
                        $"{dataRow["DELIVERYPERSON_NAME"].ToString()} {dataRow["DELIVERYPERSON_SURNAME"].ToString()}",
                       DateTime.Parse(dataRow["DELIVERYDATE"].ToString())));

                   
                    }
                   
                } else entranceCards = null;
            }
            catch (Exception ex) { }
            finally { }

            return entranceCards;
        }
        public List<EntranceCard> EntranceCardBySeriNo(string procuderName, string entranceCardSeriNo){
            List<EntranceCard> entranceCards = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@entrancecardserino", entranceCardSeriNo));
                if (dt.Rows.Count > 0)
                {
                    entranceCards = new List<EntranceCard>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        entranceCards.Add(new EntranceCard(
                       Guid.Parse(dataRow["ENTRANCECARDID"].ToString()),
                       dataRow["ENTRANCECARDSERINO"].ToString(),
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

            return entranceCards;
        }

        public static EntranceCardDal GetInstance()
        {
            if (entranceCardDal == null)
            {
                entranceCardDal = new EntranceCardDal();
            }
            return entranceCardDal;
        }

        public string Update(EntranceCard entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(EntranceCard entity)
        {
            throw new NotImplementedException();
        }
    }
}
