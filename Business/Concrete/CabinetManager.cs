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
    public class CabinetManager : IRepository<Cabinet>
    {
        static CabinetManager cabinetManager;
        CabinetDal cabinetDal;
        public CabinetManager()
        {
            cabinetDal = CabinetDal.GetInstance();
        }
        public string Add(Cabinet entity)
        {
            try
            {
                return cabinetDal.Add(entity);
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
                    return "Silmek İçin Lütfen Geçerli Bir Dolap Seçiniz.";
                }
                return cabinetDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public Cabinet Get(Guid id)
        {
            throw new NotImplementedException();
        }
        public List<Cabinet> GetAll()
        {
            try
            {
                return cabinetDal.GetAll();
            }
            catch (Exception)
            {

                return new List<Cabinet>();
            }
        }

        public List<Cabinet> CabinetByDeliveryEmployee(string procuderName, string deliveryEmployeeName)
        {
            try
            {
                if (deliveryEmployeeName == null)
                {
                    return null;
                }
                return cabinetDal.CabinetByDeliveryEmployee(procuderName, deliveryEmployeeName);
            }
            catch (Exception)
            {

                return new List<Cabinet>();
            }
        }
        public List<Cabinet> CabinetByReceiverEmployee(string procuderName, string receiverEmployeeName)
        {
            try
            {
                if (receiverEmployeeName == null)
                {
                    return null;
                }
                return cabinetDal.CabinetByReceiverEmployee(procuderName, receiverEmployeeName);
            }
            catch (Exception)
            {

                return new List<Cabinet>();
            }
        }
        public List<Cabinet> CabinetByCabinetNo(string procuderName, string cabinetNo)
        {
            try
            {
                if (cabinetNo == null)
                {
                    return null;
                }
                return cabinetDal.CabinetByCabinetNo(procuderName, cabinetNo);
            }
            catch (Exception)
            {

                return new List<Cabinet>();
            }
        }


        public static CabinetManager GetInstance()
        {
            if (cabinetManager == null)
            {
                cabinetManager = new CabinetManager();

            }
            return cabinetManager;
        }
        public string Update(Cabinet entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(Cabinet entity)
        {
            throw new NotImplementedException();
        }
    }
}
