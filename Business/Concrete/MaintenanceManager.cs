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

    public class MaintenanceManager
    {
        static MaintenanceManager maintenanceManager;
        MaintenanceDal maintenanceDal;
        public MaintenanceManager()
        {
            maintenanceDal=MaintenanceDal.GetInstance();
        }
        public static MaintenanceManager GetInstance()
        {
            if (maintenanceManager == null)
            {
                maintenanceManager = new MaintenanceManager();
            }return maintenanceManager;
        }
        public List<Maintenance> GetAll()
        {

            try
            {
                return maintenanceDal.GetAll();
            }
            catch (Exception)
            {

                return new List<Maintenance>();
            }
        }

        public Maintenance Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Add(Maintenance entity)
        {
            try
            {
                return maintenanceDal.Add(entity);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Update(Maintenance entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(Maintenance entity)
        {
            try
            {
                if (entity.ContractId == null)
                {
                    return " Güncellemek İstediğiniz Bakımı Seçiniz";

                }

                return maintenanceDal.UpdateNew(entity);
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
                if (id == Guid.Empty)
                {
                    return "Silmek İçin Lütfen Geçerli Bir Bakım Seçiniz.";
                }
                return maintenanceDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        

    }
}
