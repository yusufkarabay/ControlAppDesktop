using DataAccess.Abstract;
using DataAccess.Database;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class MaintenanceMonthDal : SqlService, IRepository<MaintenanceMonth>
    {
        static MaintenanceMonthDal maintenanceMonthDal;
        SqlService sqlService;
        public MaintenanceMonthDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }
        public static MaintenanceMonthDal GetInstance()
        {
            if (maintenanceMonthDal==null)
            {
                maintenanceMonthDal = new MaintenanceMonthDal();
            }
            return maintenanceMonthDal;
        }
        public string Add(MaintenanceMonth entity)
        {
            throw new NotImplementedException();
        }

        public string Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public MaintenanceMonth Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<MaintenanceMonth> GetAll()
        {
            List<MaintenanceMonth> maintenanceMonths = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2("MaintenanceMonthList");
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    maintenanceMonths = new List<MaintenanceMonth>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        maintenanceMonths.Add(new MaintenanceMonth(

                       int.Parse(dataRow["MAINTENANCEMONTH"].ToString())));
                        
                    }
                }
            }
            catch (Exception ex) { }
            finally { }

            return maintenanceMonths;
        }

        public string Update(MaintenanceMonth entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(MaintenanceMonth entity)
        {
            throw new NotImplementedException();
        }
    }
}
