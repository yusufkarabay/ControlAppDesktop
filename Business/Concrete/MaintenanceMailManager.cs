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
    public class MaintenanceMailManager
    {
        static MaintenanceMailManager maintenanceMailManager;
        MaintenanceMailDal maintenanceMailDal;
        public MaintenanceMailManager()
        {
            maintenanceMailDal = MaintenanceMailDal.GetInstance();
        }
        public static MaintenanceMailManager GetInstance()
        {
            if (maintenanceMailManager == null)
            {
                maintenanceMailManager = new MaintenanceMailManager();
            }
            return maintenanceMailManager;
        }
        public List<MaintenanceMail> GetAll()
        {

            try
            {
                return maintenanceMailDal.GetAll();
            }
            catch (Exception)
            {

                return new List<MaintenanceMail>();
            }
        }
        public string UpdateNew(MaintenanceMail entity)
        {
            try
            {
                if (entity.MaintenanceMailId == null)
                {
                    return " Güncellemek İstediğiniz Mail Adresini Seçiniz";

                }

                return maintenanceMailDal.UpdateNew(entity);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public string Add(MaintenanceMail entity)
        {
            try
            {
                return maintenanceMailDal.Add(entity);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

    }
}
