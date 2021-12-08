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
                dataReader = sqlService.StoreReader("RequestCreate", new SqlParameter("@requesttitle", entity.RequestTitle), new SqlParameter("@requestcontent", entity.RequestContent));
                if (dataReader.Read())
                {
                    result = dataReader[0].ConBool();
                }
                dataReader.Close();
                if (result)
                {
                    return entity.RequestTitle + " Başlığıyle Farklı Bir Talep Bulunmaktadır..";

                }
                else
                {
                    return entity.RequestTitle + " Talep Başarıyla Oluşturuldu";
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
                sqlService.Stored("RequestDelete", new SqlParameter("@requestid", id));
                return "Talep Kaydı Başarıyla Silindi";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Request Get(Guid id)
        {
            return null;
        }

        public List<Request> GetAll()
        {
            try
            {

                List<Request> list = new List<Request>();
                dataReader = sqlService.StoreReader("RequestList");
                while (dataReader.Read())
                {
                    list.Add(new Request(dataReader["REQUESTTITLE"].ToString(), dataReader["REQUESTCONTENT"].ToString(), dataReader["DATE"].ConDate()));
                }
                dataReader.Close();
                return list;
            }
            catch
            {

                return new List<Request>();
            }
        }

        public string Update(Request entity, string oldName)
        {
            try
            {
                dataReader = sqlService.StoreReader("RequestUpdate", new SqlParameter("@requestid", entity.RequestId),
                    new SqlParameter("@rewusttitle", entity.RequestTitle), new SqlParameter("@rewustcontent", entity.RequestContent));
                if (dataReader.Read())
                {
                    result = dataReader[0].ConBool();
                }
                if (result)
                {
                    return entity.RequestTitle + " Adıyla Başka Bir Talep Oluşturulmuştur";
                }
                return entity.RequestTitle + " Talep Başarıyla Güncellendi";
            }
            catch (Exception ex)
            {

                return ex.Message;

            }
        }
    }
}
