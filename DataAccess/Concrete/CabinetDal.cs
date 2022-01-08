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
    public class CabinetDal : SqlService, IRepository<Cabinet>
    {
        static CabinetDal cabinetDal;
        SqlService sqlService;
        public CabinetDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }
        public string Add(Cabinet entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("CabinetDelivery", new SqlParameter("@cabinetno", entity.CabinetNo),
                    new SqlParameter("@receiveremployee", entity.ReceiverEmployee), new SqlParameter("@deliveriyemployee", entity.DeliveryEmployee),
                    new SqlParameter("@deliverydate", entity.DeliveryDate));
                if (isSuccess)
                {
                    return entity.CabinetNo + " Numaralı Dolap Teslim Edilmişitir";
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
                var (isSuccess, msg) = sqlService.StoreReaderV2("CabinetReturnDelivery", new SqlParameter("@cabinetid", id));
                if (isSuccess)
                {
                    result = "Dolap Başarı İle Teslim Alındı";
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
        public Cabinet Get(Guid id)
        {
            throw new NotImplementedException();
        }
        public List<Cabinet> GetAll()
        {
            List<Cabinet> cabinets = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2("CabinetList");
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    cabinets = new List<Cabinet>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        cabinets.Add(new Cabinet(
                       Guid.Parse(dataRow["CABINETID"].ToString()),
                       dataRow["CABINETNO"].ToString(),
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

            return cabinets;
        }
        public List<Cabinet> CabinetByDeliveryEmployee(string procuderName, string deliveryEmployeeName)
        {
            List<Cabinet> cabinets = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@deliveryemployee", deliveryEmployeeName));

                if (dt.Rows.Count > 0)
                {
                    cabinets = new List<Cabinet>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        cabinets.Add(new Cabinet(
                         Guid.Parse(dataRow["CABINETID"].ToString()),
                         dataRow["CABINETNO"].ToString(),
                         dataRow["RECEIVEREMPLOYEE"].ToString(),
                         $"{dataRow["RECEIVERPERSON_NAME"].ToString()} {dataRow["RECEIVERPERSON_SURNAME"].ToString()}",
                         dataRow["DELIVERYEMPLOYEE"].ToString(),
                          $"{dataRow["DELIVERYPERSON_NAME"].ToString()} {dataRow["DELIVERYPERSON_SURNAME"].ToString()}",
                         DateTime.Parse(dataRow["DELIVERYDATE"].ToString())));


                    }
                }
                else cabinets = null;
            }

            catch (Exception ex) { }
            finally { }

            return cabinets;
        }
        public List<Cabinet> CabinetByReceiverEmployee(string procuderName, string receiverEmployeeName)
        {
            List<Cabinet> cabinets = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@receiveremployee", receiverEmployeeName));

                if (dt.Rows.Count > 0)
                {
                    cabinets = new List<Cabinet>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        cabinets.Add(new Cabinet(
                         Guid.Parse(dataRow["CABINETID"].ToString()),
                         dataRow["CABINETNO"].ToString(),
                         dataRow["RECEIVEREMPLOYEE"].ToString(),
                         $"{dataRow["RECEIVERPERSON_NAME"].ToString()} {dataRow["RECEIVERPERSON_SURNAME"].ToString()}",
                         dataRow["DELIVERYEMPLOYEE"].ToString(),
                          $"{dataRow["DELIVERYPERSON_NAME"].ToString()} {dataRow["DELIVERYPERSON_SURNAME"].ToString()}",
                         DateTime.Parse(dataRow["DELIVERYDATE"].ToString())));


                    }
                }
                else cabinets = null;
            }

            catch (Exception ex) { }
            finally { }

            return cabinets;
        }
        public List<Cabinet> CabinetByCabinetNo(string procuderName, string cabinetNo)
        {
            List<Cabinet> cabinets = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@cabinetno", cabinetNo));

                if (dt.Rows.Count > 0)
                {
                    cabinets = new List<Cabinet>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        cabinets.Add(new Cabinet(
                         Guid.Parse(dataRow["CABINETID"].ToString()),
                         dataRow["CABINETNO"].ToString(),
                         dataRow["RECEIVEREMPLOYEE"].ToString(),
                         $"{dataRow["RECEIVERPERSON_NAME"].ToString()} {dataRow["RECEIVERPERSON_SURNAME"].ToString()}",
                         dataRow["DELIVERYEMPLOYEE"].ToString(),
                          $"{dataRow["DELIVERYPERSON_NAME"].ToString()} {dataRow["DELIVERYPERSON_SURNAME"].ToString()}",
                         DateTime.Parse(dataRow["DELIVERYDATE"].ToString())));


                    }
                }
                else cabinets = null;
            }

            catch (Exception ex) { }
            finally { }

            return cabinets;
        }
        public string Update(Cabinet entity, string oldName)
        {
            throw new NotImplementedException();
        }
        public string UpdateNew(Cabinet entity)
        {
            throw new NotImplementedException();
        }
        public static CabinetDal GetInstance()
        {
            if (cabinetDal == null)
            {
                cabinetDal = new CabinetDal();
            }
            return cabinetDal;
        }
    }
}
