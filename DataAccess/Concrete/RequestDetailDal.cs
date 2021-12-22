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

        public string Update(RequestDetail entity,string oldName)
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
                        RequestDetail requestDetail = new RequestDetail((Guid)dataRow["REQUESTDETAILID"], (Guid)dataRow["REQUESTID"], dataRow["NAME"].ToString() + " " + dataRow["SURNAME"].ToString(),
                        dataRow["REQUESTTITLE"].ToString(), dataRow["REQUESTCONTENT"].ToString());

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
