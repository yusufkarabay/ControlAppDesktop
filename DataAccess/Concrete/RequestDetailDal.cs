using DataAccess.Abstract;
using DataAccess.Database;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



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
                dataReader = sqlService.StoreReader("RequestAssignmentCreate", new SqlParameter("@requestid", entity.RequestId), new SqlParameter("@requesting", entity.Requesting), new SqlParameter("@requested", entity.Requested));
                if (dataReader.Read())
                {
                    result = dataReader[0].ConBool();
                }
                dataReader.Close();
                if (result)
                {
                    return "Bu Talep Daha Önce " + entity.RequestedName + " İsimli Personele İletilmiştir.";
                }
                return entity.RequestedName+ " İsimli Personele Talep Başarıyla Oluşturulmuştur";
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
    }
}
