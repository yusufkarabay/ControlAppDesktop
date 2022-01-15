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
    public class MaintenanceDal : SqlService, IRepository<Maintenance>
    {
        static MaintenanceDal maintenanceDal;
        SqlService sqlService;
        public MaintenanceDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }
        public static MaintenanceDal GetInstance()
        {
            if (maintenanceDal == null)
            {
                maintenanceDal = new MaintenanceDal();
            }
            return maintenanceDal;
        }
        public string Add(Maintenance entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("MaintenanceAdd", new SqlParameter("@contractid", entity.ContractId),
                    new SqlParameter("@contractname", entity.ContractName),
                    new SqlParameter("@maintenancemonth", entity.MaintenanceMonth), new SqlParameter("@firstmaintenancedate", entity.FirstMaintenanceDate));
                if (isSuccess)
                {
                    return "Bakım  Kaydedilmiştir.";
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
                var (isSuccess, msg) = sqlService.StoreReaderV2("MaintenanceDelete", new SqlParameter("@maintenanceid", id));
                if (isSuccess)
                {
                    result = "Hatırlatma Başarı İle Silindi";
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

        public Maintenance Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Maintenance> GetAll()
        {
            List<Maintenance> maintenances = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2("MaintenanceAllList");
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    maintenances = new List<Maintenance>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        maintenances.Add(new Maintenance(

                       
                       Guid.Parse(dataRow["CONTRACTID"].ToString()),
                       dataRow["CONTRACTNAME"].ToString(),
                        Guid.Parse(dataRow["MAINTENANCEID"].ToString()),
                       int.Parse(dataRow["MAINTENANCEMONTH"].ToString()),
                       DateTime.Parse(dataRow["FIRSTMAINTENANCEDATE"].ToString())));




                    }
                }
            }
            catch (Exception ex) { }
            finally { }

            return maintenances;
        }

        public string Update(Maintenance entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(Maintenance entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("MaintenanceUpdate", new SqlParameter("@maintenanceid",
                    entity.MaintenanceId), new SqlParameter("@contractid",
                    entity.ContractId), new SqlParameter("@contractname", entity.ContractName), new SqlParameter("@maintenancemonth", entity.MaintenanceMonth),
                    new SqlParameter("@firstmaintenancedate", entity.FirstMaintenanceDate));
                if (isSuccess)
                {
                    result = "Bakım Başarı İle Güncellendi";
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
