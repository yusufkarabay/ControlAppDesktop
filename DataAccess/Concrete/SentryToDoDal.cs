using DataAccess.Abstract;
using DataAccess.Database;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess.Concrete
{
    public class SentryToDoDal : SqlService, IRepository<SentryToDo>
    {
        static SentryToDoDal sentryToDoDal;
        SqlService sqlService;
        SentryToDo sentryToDo;
        public SentryToDoDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }
        public string Add(SentryToDo entity)
        {
            string result = null;
            try
            {
                var (isSucces, msg) = sqlService.StoredV2("SentryToDoCreat", new SqlParameter("@todo", entity.ToDo),
                    new SqlParameter("@createdtime", entity.CreatedTime), new SqlParameter("@createdemployee", entity.CreatedEmployee));
                return "Yapılacak İş Başarı ile Eklendi";
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
                var (isSuccess, msg) = sqlService.StoreReaderV2("SentryToDoDelete", new SqlParameter("@todosentryid", id));

                if (isSuccess)
                {
                    result = "Yapılacak İş  Başarı İle Silindi";
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

        public SentryToDo Get(Guid id)
        {

            throw new NotImplementedException();
        }

        public List<SentryToDo> GetAll()
        {

            throw new NotImplementedException();
        }
        public List<SentryToDo> GetSentryToDoByDate(string procuderName, DateTime date)
        {
            List<SentryToDo> sentryTodos = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@createdtime", date));
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    sentryTodos = new List<SentryToDo>();

                    foreach (DataRow dataRow in dt.Rows)
                    {

                        sentryTodos.Add
                           (new SentryToDo(
                           (Guid)dataRow["TODOSENTRYID"],
                          dataRow["TODO"].ToString(),
                          dataRow["CREATEDTIME"].ConDate(),
                          dataRow["TC"].ToString(),
                          $"{dataRow["NAME"].ToString()} {dataRow["SURNAME"].ToString()}"
                          )
                       );

                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally { }
            return sentryTodos;//**************** bu kısmı sor?
        }
        public string Update(SentryToDo entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public SentryToDo GetSentryToDo(Guid todoSentryId)
        {
            SentryToDo sentryToDo = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2("SentryToDoGetId", new SqlParameter("@todosentryid", todoSentryId));
                if (msg != null)
                {
                    return null;

                }
                if (sentryToDo != null)
                {
                    string toDo;
                    DateTime createdTime;
                    string createdEmployee;

                    todoSentryId = sentryToDo.SentryToDoId;
                    toDo = sentryToDo.ToDo;
                    createdTime = sentryToDo.CreatedTime;
                    createdEmployee = sentryToDo.CreatedEmployee;

                    sentryToDo = new SentryToDo
                    {
                        SentryToDoId = todoSentryId,
                        CreatedTime = createdTime,
                        CreatedEmployee = createdEmployee
                    };
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            }
            return sentryToDo;

        }

        public string UpdateNew(SentryToDo entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("SentryToDoUpdate", new SqlParameter("@todosentryid", entity.SentryToDoId),
                    new SqlParameter("@todo", entity.ToDo), new SqlParameter("@createdtime", entity.CreatedTime),
                     new SqlParameter("@createdemployee", entity.CreatedEmployee));
                if (isSuccess)
                {
                    result = "Yapılacak İş Başarı İle Güncellendi";
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
        public static SentryToDoDal GetInstance()
        {
            if (sentryToDoDal == null)
            {
                sentryToDoDal = new SentryToDoDal();
            }
            return sentryToDoDal;
        }
    }
}
