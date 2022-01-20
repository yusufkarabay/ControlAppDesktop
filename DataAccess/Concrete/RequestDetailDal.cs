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
    public class RequestDetailDal : IRepository<RequestDetail>
    {
        static RequestDetailDal requestDetailDal;
        SqlService sqlService;
        SqlDataReader dataReader;
        bool result;
        public RequestDetailDal()
        {
            sqlService = SqlDatabase.GetInstance();

        }

        public List<RequestDetail> GetByDepartmentId(string proceduerName, Guid departmentId)
        {
            List<RequestDetail> requestDetails = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2(proceduerName, new SqlParameter("@departmentid", departmentId));
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    requestDetails = new List<RequestDetail>();

                    foreach (DataRow dataRow in dt.Rows)
                    {
                        requestDetails.Add(new RequestDetail(

                        Guid.Parse(dataRow["REQUESTDETAILID"].ToString()),

                        Guid.Parse(dataRow["REQUESTID"].ToString()),

                        dataRow["REQUESTTITLE"].ToString(),

                        dataRow["REQUESTCONTENT"].ToString(),

                        DateTime.Parse(dataRow["REQUESTTIME"].ToString()),

                        Guid.Parse(dataRow["DEPARTMENTID"].ToString()),
                          dataRow["DEPARTMENTNAME"].ToString(),

                        dataRow["REQUESTING"].ToString(),
                        $"{dataRow["NAME"]}{dataRow["SURNAME"]}"
                        //,
                        //dataRow["REQUESTED"].ToString(),
                        //$"{dataRow["NAME"]}{dataRow["SURNAME"]}"
                        ));


                    }
                }
            }
            catch (Exception ex) { }
            finally { }

            return requestDetails;
        }
        public string Add(RequestDetail entity)
        {
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("RequestAssignmentCreate", new SqlParameter("@requestid", entity.RequestId), new SqlParameter("@requesting", entity.Requesting), new SqlParameter("@requested", entity.Requested));
                if (isSuccess)
                {
                    return entity.Requested + " İsimli Personele Talep Başarıyla Oluşturulmuştur";
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
        public string RequestToDepartment(RequestDetail entity)
        {

            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoredV2("RequestToDepartment",
                    new SqlParameter("@requestid", entity.RequestId),
                    new SqlParameter("@requesting", entity.Requesting),
                    new SqlParameter("@departmentid", entity.DepartmentId),
                    new SqlParameter("@issend", entity.IsSend));
                // new SqlParameter("@requested", entity.Requested));

                return "  Talep Başarıyla Oluşturulmuştur";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            return result;
        }
        public string UpdateBool(RequestDetail entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("RequestChangeBool",
                    new SqlParameter("@requestid", entity.RequestId),
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

        public string RequestTakeToMe(RequestDetail entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("RequestTakeToMe", new SqlParameter("@requestid", entity.RequestId),
                    new SqlParameter("@requested", entity.Requested));
                if (isSuccess)
                {
                    result = "Talep  Başarı İle Size Teslim Edildi";
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
        public string End(RequestDetail entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("RequestEnd",
                    new SqlParameter("@requestdetailid", entity.RequestDetailId),
                    new SqlParameter("@requestendtext", entity.RequestEndText),
                    new SqlParameter("@isfinished", entity.IsEnd));
                if (isSuccess)
                {
                    result = "Talep  Başarı İle Sonlandırılmıştır";
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
        public string Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public RequestDetail Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<RequestDetail> GetAll()
        {
            throw new NotImplementedException();
        }


        public string Update(RequestDetail entity, string oldName)
        {
            throw new NotImplementedException();
        }
        public static RequestDetailDal GetInstance()
        {
            if (requestDetailDal == null)
            {
                requestDetailDal = new RequestDetailDal();
            }
            return requestDetailDal;
        }

        public List<RequestDetail> GetByTc(string procuderName, string tc)
        {
            List<RequestDetail> list = null;

            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@tc", tc));
                if (msg != null)
                {
                    return null;
                }

                if (dt.Rows.Count > 0)
                {
                    list = new List<RequestDetail>();

                    foreach (DataRow dataRow in dt.Rows)
                    {
                        RequestDetail requestDetail = new RequestDetail(
                        (Guid)dataRow["REQUESTDETAILID"],
                        (Guid)dataRow["REQUESTID"],
                        dataRow["NAME"].ToString() + " " + dataRow["SURNAME"].ToString(),
                        dataRow["REQUESTTITLE"].ToString(),
                        dataRow["REQUESTCONTENT"].ToString(),
                        DateTime.Parse(dataRow["REQUESTTIME"].ToString()),
                       (Guid)dataRow["DEPARTMENTID"]);

                        list.Add(requestDetail);
                    }
                }

            }
            catch (Exception ex) { }
            finally { }

            return list;
        }

        public string UpdateNew(RequestDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
