using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess.Database;

namespace DataAccess.Concrete
{
    public class RequestDal : IRepository<Request>
    {
        static RequestDal requestDal;
        SqlService sqlService;
        SqlDataReader dataReader;
        bool result;
        public RequestDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }
        public string Add(Request entity)
        {
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("RequestCreate", new SqlParameter("@requesttitle", entity.RequestTitle),
                    new SqlParameter("@requestcontent", entity.RequestContent),
                    new SqlParameter("@requesttime", entity.RequestTime),new SqlParameter("@createdemployee",entity.CreatedEmployee));
                if (isSuccess)
                {
                    return entity.RequestTitle + " Talep Başarıyla Oluşturuldu";
                }
                else
                {
                    return msg;
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Delete(Guid id)
        {
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("RequestDelete", new SqlParameter("@requestid", id));
                if (isSuccess)
                {
                    return "Talep Kaydı Başarıyla Silindi";
                }
                else
                {
                    return msg;
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Request Get(Guid id)
        {
            Request request = null;
            try
            {
                // veritabanındaki requestList prosdürü id parametresi almıyor. alması gerek, Id'ye göre request seçebilmek için
                // sonra o requestId parametresini storedV2 prosedürüne göndermek gerek.
                var (dt, msg) = sqlService.StoredV2("RequestList");
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        request = new Request(dataRow["REQUESTTITLE"].ToString(), dataRow["REQUESTCONTENT"].ToString(), dataRow["DATE"].ConDate());
                    }
                }
            }
            catch (Exception ex) { }
            finally { }
            return request;
        }

        public List<Request> GetAll()
        {
            List<Request> list = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2("RequestList");
                if (msg != null)
                {
                    return null;
                }

                if (dt.Rows.Count > 0)
                {
                    list = new List<Request>();

                    foreach (DataRow dataRow in dt.Rows)
                    {
                        list.Add(new Request(
                            Guid.Parse(dataRow["REQUESTID"].ToString()),
                            dataRow["REQUESTTITLE"].ToString(),
                            dataRow["REQUESTCONTENT"].ToString(),
                            DateTime.Parse(dataRow["REQUESTTIME"].ToString())));
                    }
                }

            }
            catch (Exception ex) { }
            finally { }

            return list;
        }
        public List<Request> GetByDepartmentId(string procuderName, Guid departmentId)
        {
            List<Request> list = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@departmentid", departmentId));
                if (msg != null)
                {
                    return null;
                }

                if (dt.Rows.Count > 0)
                {
                    list = new List<Request>();

                    foreach (DataRow dataRow in dt.Rows)
                    {
                        list.Add(new Request(
                            Guid.Parse(dataRow["REQUESTID"].ToString()),
                            dataRow["REQUESTTITLE"].ToString(),
                            dataRow["REQUESTCONTENT"].ToString(),
                            DateTime.Parse(dataRow["REQUESTTIME"].ToString())));
                    }
                }

            }
            catch (Exception ex) { }
            finally { }

            return list;
        }

        public string Update(Request entity, string oldName)
        {
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("RequestUpdate", new SqlParameter("@requestid", entity.RequestId),
                    new SqlParameter("@requsttitle", entity.RequestTitle), new SqlParameter("@requstcontent", entity.RequestContent));
                if (isSuccess)
                {
                    return entity.RequestTitle + " Talep Başarıyla Güncellendi";
                }
                else
                {
                    return msg;
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public static RequestDal GetInstance()
        {
            if (requestDal == null)
            {
                requestDal = new RequestDal();
            }
            return requestDal;
        }
        public string RequestIsSend(Request entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("RequestIsSend", new SqlParameter("@requestid", entity.RequestId),
                     new SqlParameter("@issend", entity.IsSend));
                if (isSuccess)
                {
                    result = "Talep   Başarı İle Gönderildi";
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
        public List<Request>  RequestSendedList(string procuderName, string createdEmployee)
        {//"RequestSendedList"
            List<Request> list = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@createdemployee", createdEmployee));
                if (msg != null)
                {
                    return null;
                }

                if (dt.Rows.Count > 0)
                {
                    list = new List<Request>();

                    foreach (DataRow dataRow in dt.Rows)
                    {
                        list.Add(new Request(
                            Guid.Parse(dataRow["REQUESTID"].ToString()),
                            dataRow["REQUESTTITLE"].ToString(),
                            dataRow["REQUESTCONTENT"].ToString(),
                            DateTime.Parse(dataRow["REQUESTTIME"].ToString()),
                            dataRow["CREATEDEMPLOYEE"].ToString()));
                    }
                }

            }
            catch (Exception ex) { }
            finally { }

            return list;
        }

        public string UpdateNew(Request entity)
        {
            throw new NotImplementedException();
        }
    }
}
