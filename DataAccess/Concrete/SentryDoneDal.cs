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
    public class SentryDoneDal : SqlService, IRepository<SentryDone>
    {
        static SentryDoneDal sentryDoneDal;
        SqlService sqlService;
        SentryDone sentryDone;
        Employee employee;

        public SentryDoneDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }
        public string Add(SentryDone entity)
        {
            string result = null;
            try
            {
                var (isSucces, msg) = sqlService.StoredV2("SentryDoneCreate", new SqlParameter("@done", entity.Done),
                    new SqlParameter("@createdtime", entity.CreatedTime), new SqlParameter("@createdemployee", entity.CreatedEmployee));
                return "Yapılan İş Başarı ile Eklendi";
            }

            catch (Exception ex)
            {

                return ex.Message;
            }
            return result;
        }


        public string GetSetryByDate(string procuderName, DateTime dateTime)
        {
            List<SentryDone> sentryDones = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2("SentryDoneGetByDate", new SqlParameter("@createdtime", dateTime));
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        Guid sentrydoneId;
                        string done;
                        DateTime createdTime;
                        string createdEmployee;

                        sentrydoneId = (Guid)dataRow["SENTRYDONEID"];
                        done = dataRow["DONE"].ToString();
                        createdTime = dataRow["CREATEDTIME"].ConDate();
                        createdEmployee = dataRow["CREATEDEMPLOYEE"].ToString();
                        sentryDone = new SentryDone
                        {
                            SentrydoneId = sentrydoneId,
                            Done = done,
                            CreatedTime = createdTime,
                            CreatedEmployee = createdEmployee
                        };

                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return sentryDones.ToString();//**************** bu kısmı sor?
        }


        public string Delete(Guid id)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("SentryDoneDelete", new SqlParameter("@donesentryid", id));
                if (isSuccess)
                {
                    result = "Yapılan İş " + employee.Name + " " + employee.Surname + " İsimli Personel Tarafondan Başarı İle Silindi";
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

        public SentryDone Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<SentryDone> GetAll()
        {
            throw new NotImplementedException();
        }

        public string Update(SentryDone entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(SentryDone entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("SentryDoneUpdate", new SqlParameter("@donesentryid", entity.SentrydoneId),
                    new SqlParameter("done", entity.Done), new SqlParameter("createdtime", entity.CreatedTime), new SqlParameter("createdemployee", entity.CreatedEmployee));
                if (isSuccess)
                {
                    return "Yapılan İş Başarı İle Güncellendi";
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
        public static SentryDoneDal GetInstance()
        {
            if (sentryDoneDal == null)
            {
                sentryDoneDal = new SentryDoneDal();
            }
            return sentryDoneDal;
        }
    }
}
