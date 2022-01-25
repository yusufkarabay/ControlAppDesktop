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
        LogService logService;
       

        public SentryDoneDal()
        {
            sqlService = SqlDatabase.GetInstance();
            logService = LogService.GetIntance();
        }
        public string Add(SentryDone entity)
        {
            string result = null;
            try
            {
               
                var (isSucces, msg) = sqlService.StoredV2("SentryDoneCreate",
                    new SqlParameter("@done", entity.Done),
                    new SqlParameter("@createdtime", entity.CreatedTime),
                    new SqlParameter("@createdemployee", entity.CreatedEmployee),
                    new SqlParameter("@departmentid",entity.DepartmentId));
               // return "Yapılan İş Başarı ile Eklendi";

                return logService.Info("Yapılan İş Ekleme","Yapılan İş: "+entity.Done,"Ekleme Zamanı: "+entity.CreatedTime,"Ekleyen Personel: " + entity.CreatedEmployee,
                    "Ekleyen Personel Departmanı: "+entity.DepartmentId);
            }

            catch (Exception ex)
            {

                // return ex.Message;
             return   logService.Error(ex.Message, "Yapılan İş Ekleme", "Yapılan İş: " + entity.Done, "Ekleme Zamanı: " + entity.CreatedTime,
                 "Ekleyen Personel: " + entity.CreatedEmployee,"Ekleyen Personel Departmanı: " + entity.DepartmentId);
            }
            return result;
        }


        public List<SentryDone> GetSentryByDate(string procuderName, DateTime date, Guid departmentId)
        {
            List<SentryDone> sentryDones = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@createdtime", date),new SqlParameter("@departmentid",departmentId));
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    sentryDones = new List<SentryDone>();

                    foreach (DataRow dataRow in dt.Rows)
                    {
                        sentryDones.Add(
                            new SentryDone(
                               (Guid)dataRow["DONESENTRYID"],
                              dataRow["DONE"].ToString(),
                              dataRow["CREATEDTIME"].ConDate(),
                              dataRow["TC"].ToString(),
                              $"{dataRow["NAME"].ToString()} {dataRow["SURNAME"].ToString()}",
                              (Guid)dataRow["DEPARTMENTID"]
                            )
                        );

                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally { }
            return sentryDones;
        }

        public SentryDone GetSentryDone(Guid donesentryid)
        {
            SentryDone sentryDone = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2("SentryDoneGet", new SqlParameter("@donesentryid", donesentryid));
                if (msg != null)
                {
                    return null;
                }
                if (sentryDone != null)
                {

                    string done;
                    DateTime createdTime;
                    string createdEmployee;

                    donesentryid = sentryDone.SentrydoneId;
                    done = sentryDone.Done;
                    createdTime = sentryDone.CreatedTime;
                    createdEmployee = sentryDone.CreatedEmployee;

                    sentryDone = new SentryDone
                    {
                        SentrydoneId = donesentryid,
                        CreatedTime = createdTime,
                        CreatedEmployee = createdEmployee,
                        Done = done
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
            return sentryDone;

        }


        public string Delete(Guid id,string createdemployee)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("SentryDoneDelete", new SqlParameter("@donesentryid", id),new SqlParameter("@createdemployee", createdemployee));
               
                if (isSuccess)
                {
                    //  result = "Yapılan İş  Başarı İle Silindi";
                    
                 return "Yapılan İş Silinmişitr" + logService.Info("Yapılan İş Sil", "İş Id: " + id);
                          
                }
                else
                {
                    result = msg;
                }
            }
            catch (Exception ex)
            {

                return logService.Error(ex.Message,"Yapılan İş Sil", "İş Id: " + id);
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
                    new SqlParameter("@done", entity.Done), new SqlParameter("@createdtime", entity.CreatedTime)
                    , new SqlParameter("@createdemployee", entity.CreatedEmployee));
                if (isSuccess)
                {
                    result= "Yapılan İş Başarı İle Güncellendi";
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

        public string Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
