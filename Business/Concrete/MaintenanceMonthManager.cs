using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Business.Concrete
{
    public class MaintenanceMonthManager
    {
        static MaintenanceMonthManager maintenanceMonthManager;
        MaintenanceMonthDal maintenanceMonthDal;
        public MaintenanceMonthManager()
        {
            maintenanceMonthDal=MaintenanceMonthDal.GetInstance();
        }
        public static MaintenanceMonthManager GetInstance()
        {
            if (maintenanceMonthManager == null)
            {
                maintenanceMonthManager = new MaintenanceMonthManager();
            }
            return maintenanceMonthManager;
        }
        public List<MaintenanceMonth> GetAll()
        {

            try
            {
                return maintenanceMonthDal.GetAll();
            }
            catch (Exception)
            {

                return new List<MaintenanceMonth>();
            }
        }
    }
}
