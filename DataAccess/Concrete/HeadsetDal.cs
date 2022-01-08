using DataAccess.Abstract;
using DataAccess.Database;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DataAccess.Concrete
{
    public class HeadsetDal : SqlService, IRepository<Headset>
    {
        static HeadsetDal headsetDal;
        SqlService sqlService;
        Employee employee;


        public HeadsetDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }
        public string Add(Headset entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("HeadsetDelivery", new SqlParameter("@headsetserino", entity.HeadsetSeriNo),
                    new SqlParameter("@receiverperson", entity.ReceiverPerson), new SqlParameter("@deliveryperson", entity.DeliveryPerson),
                    new SqlParameter("@headsetstatusinfo", entity.HeadsetStatusInfo), new SqlParameter("@deliverydate", entity.DeliveryDate));
                if (isSuccess)
                {
                    return entity.HeadsetSeriNo + " Seri Numaralı Kulaklık Teslim Edilmişitir";
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
                var (isSuccess, msg) = sqlService.StoreReaderV2("HeadsetReturnDelivery", new SqlParameter("@headsetid", id));
                if (isSuccess)
                {
                    result = "Kulaklık Başarı İle Teslim Alındı";
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
        public Headset GetByEmployeeName(string procuderName, string receiverPerson)
        {
            if (string.IsNullOrEmpty(procuderName))
                throw new ArgumentNullException("Prosedür name null geçilemez");

            if (string.IsNullOrEmpty(receiverPerson))
                throw new ArgumentNullException("Receiver person null geçilemez");

            Headset headset = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2("HeadsetByEmployeeName", new SqlParameter("@receiverperson", receiverPerson));
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        Guid headsetId;
                        string headsetSeriNo;
                        string deliveryPerson;
                        string headsetStatusInfo;
                        DateTime deliveryDate;


                        headsetId = (Guid)dataRow["HEADSETSERINO"];
                        deliveryPerson = dataRow["HEADSETSERINO"].ToString();
                        headsetStatusInfo = dataRow["RECEIVERPERSON"].ToString();
                        deliveryDate = dataRow["DELIVERYDATE"].ConDate();
                        headsetSeriNo = dataRow["HEADSETSERINO"].ToString();

                        headset = new Headset
                        {
                            HeadsetId = headsetId,
                            HeadsetSeriNo = headsetSeriNo,
                            DeliveryPerson = deliveryPerson,
                            HeadsetStatusInfo = headsetStatusInfo,
                            DeliveryDate = deliveryDate,
                            ReceiverPerson = receiverPerson
                        };
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            }

            return headset;
        }
        public List<Headset> GetAll()
        {
            List<Headset> headsetList = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2("HeadsetList");
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    headsetList = new List<Headset>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        headsetList.Add(new Headset(
                       Guid.Parse(dataRow["HEADSETID"].ToString()),
                       dataRow["HEADSETSERINO"].ToString(),
                       dataRow["RECEIVERPERSON"].ToString(),
                       $"{dataRow["RECEIVERPERSON_NAME"].ToString()} {dataRow["RECEIVERPERSON_SURNAME"].ToString()}",
                       dataRow["DELIVERYPERSON"].ToString(),
                        $"{dataRow["DELIVERYPERSON_NAME"].ToString()} {dataRow["DELIVERYPERSON_SURNAME"].ToString()}",
                       dataRow["HEADSETSTATUSINFO"].ToString(),
                       DateTime.Parse(dataRow["DELIVERYDATE"].ToString())));

                    }
                }
            }
            catch (Exception ex) { }
            finally { }

            return headsetList;
        }
        public List<Headset> HeadsetByDeliveryEmployee(string procuderName, string deliverypersonName)
        {

            List<Headset> headsetList = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@deliverypersonName", deliverypersonName));
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    headsetList = new List<Headset>();

                    foreach (DataRow dataRow in dt.Rows)
                    {
                        headsetList.Add(new Headset(
                       Guid.Parse(dataRow["HEADSETID"].ToString()),
                       dataRow["HEADSETSERINO"].ToString(),
                       dataRow["RECEIVERPERSON"].ToString(),
                       $"{dataRow["RECEIVERPERSON_NAME"].ToString()} {dataRow["RECEIVERPERSON_SURNAME"].ToString()}",
                       dataRow["DELIVERYPERSON"].ToString(),
                        $"{dataRow["DELIVERYPERSON_NAME"].ToString()} {dataRow["DELIVERYPERSON_SURNAME"].ToString()}",
                       dataRow["HEADSETSTATUSINFO"].ToString(),
                       DateTime.Parse(dataRow["DELIVERYDATE"].ToString())));

                    }
                }
                else headsetList = null;
            }
            catch (Exception ex) { }
            finally { }

            return headsetList;
        }
        public List<Headset> HeadsetByReceiverEmployee(string procuderName, string receiverpersonName)
        {


            List<Headset> headsetList = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@receiverpersonName", receiverpersonName));
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    headsetList = new List<Headset>();

                    foreach (DataRow dataRow in dt.Rows)
                    {
                        headsetList.Add(new Headset(
                       Guid.Parse(dataRow["HEADSETID"].ToString()),
                       dataRow["HEADSETSERINO"].ToString(),
                       dataRow["RECEIVERPERSON"].ToString(),
                       $"{dataRow["RECEIVERPERSON_NAME"].ToString()} {dataRow["RECEIVERPERSON_SURNAME"].ToString()}",
                       dataRow["DELIVERYPERSON"].ToString(),
                        $"{dataRow["DELIVERYPERSON_NAME"].ToString()} {dataRow["DELIVERYPERSON_SURNAME"].ToString()}",
                       dataRow["HEADSETSTATUSINFO"].ToString(),
                       DateTime.Parse(dataRow["DELIVERYDATE"].ToString())));

                    }
                }
                else headsetList = null;
            }
            catch (Exception ex) { }
            finally { }

            return headsetList;
        }
        public List<Headset> HeadsetBySeriNo(string procuderName, string headsetserino)
        {


            List<Headset> headsetList = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@headsetserino", headsetserino));
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    headsetList = new List<Headset>();

                    foreach (DataRow dataRow in dt.Rows)
                    {
                        headsetList.Add(new Headset(
                       Guid.Parse(dataRow["HEADSETID"].ToString()),
                       dataRow["HEADSETSERINO"].ToString(),
                       dataRow["RECEIVERPERSON"].ToString(),
                       $"{dataRow["RECEIVERPERSON_NAME"].ToString()} {dataRow["RECEIVERPERSON_SURNAME"].ToString()}",
                       dataRow["DELIVERYPERSON"].ToString(),
                        $"{dataRow["DELIVERYPERSON_NAME"].ToString()} {dataRow["DELIVERYPERSON_SURNAME"].ToString()}",
                       dataRow["HEADSETSTATUSINFO"].ToString(),
                       DateTime.Parse(dataRow["DELIVERYDATE"].ToString())));

                    }
                }
                else headsetList = null;
            }
            catch (Exception ex) { }
            finally { }

            return headsetList;
        }


        public static HeadsetDal GetInstance()
        {
            if (headsetDal == null)
            {
                headsetDal = new HeadsetDal();
            }
            return headsetDal;
        }
        public string UpdateNew(Headset entity)
        {
            throw new NotImplementedException();
        }
        public string Update(Headset entity, string oldName)
        {
            throw new NotImplementedException();
        }
        public Headset Get(Guid id)
        {
            throw new NotImplementedException();
        }

    }
}
