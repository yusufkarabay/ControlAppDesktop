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
    public class MaintenanceMailDal : SqlService, IRepository<MaintenanceMail>
    {
        static MaintenanceMailDal maintenanceMailDal;
        SqlService sqlService;
        public static MaintenanceMailDal GetInstance()
        {
            if (maintenanceMailDal == null)
            {
                maintenanceMailDal = new MaintenanceMailDal();
            }
            return maintenanceMailDal;
        }
        public MaintenanceMailDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }
        public string Add(MaintenanceMail entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("MaintenanceMailAdd", new SqlParameter("@maintenanceemail", entity.MaintenanceEMail),
                    new SqlParameter("@maintenanceemployeename", entity.MaintenanceEmployeeName));
                if (isSuccess)
                {
                    return "Mail  Kaydedilmiştir.";
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
                var (isSuccess, msg) = sqlService.StoreReaderV2("MaintenanceMailDelete", new SqlParameter("@maintenancemailid", id));
                if (isSuccess)
                {
                    result = "Mail Adresi Başarı İle Silindi";
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

        public MaintenanceMail Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<MaintenanceMail> GetAll()
        {
            List<MaintenanceMail> maintenanceMails = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2("MaintenanceMailAllList");
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    maintenanceMails = new List<MaintenanceMail>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        maintenanceMails.Add(new MaintenanceMail(
                       Guid.Parse(dataRow["MAINTENANCEMAILID"].ToString()),
                       dataRow["MAINTENANCEEMAIL"].ToString(),
                        dataRow["MAINTENANCEEMPLOYEENAME"].ToString()));
                    }
                }
            }
            catch (Exception ex) { }
            finally { }

            return maintenanceMails;
        }

        public string Update(MaintenanceMail entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(MaintenanceMail entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("MaintenanceMailUpdate", new SqlParameter("@maintenancemailid", entity.MaintenanceMailId),
                    new SqlParameter("@maintenanceemail", entity.MaintenanceEMail), new SqlParameter("@maintenanceemployeename", entity.MaintenanceEmployeeName));
                if (isSuccess)
                {
                    result = "E-Mail Adresi Başarı İle Güncellendi";
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
    }
}
