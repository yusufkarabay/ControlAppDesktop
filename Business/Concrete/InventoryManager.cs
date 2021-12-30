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
    public class InventoryManager
    {
        static InventoryManager inventoryManager;
        InventoryDal inventorydal;
        string controlText;
        public InventoryManager()
        {
            inventorydal = InventoryDal.GetInstance();
        }
        string IsInventoryComplete(Inventory inventory)
        {
            if (string.IsNullOrEmpty(inventory.InventorySeriNo))
            {
                return "Lütfen Bir İş Giriniz. Boş Kayıt Girilemez";
            }
            return "";
        }
        public string Add(Inventory entity)
        {
            try
            {
                controlText = IsInventoryComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return inventorydal.Add(entity);
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
                    return "Silmek İçin Lütfen Geçerli İş Seçiniz.";
                }
                return inventorydal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Inventory> GetInventoryByCreatedDate(string procuderName, DateTime date) { throw new NotImplementedException(); }
        public List<Inventory> GetInventoryByCreatedEmployee(string procuderName, string createdEmployee) { throw new NotImplementedException(); }
        public List<Inventory> GetInventoryByName(string procuderName, string inventoryName) { throw new NotImplementedException(); }
        public Inventory GetInventoryBySeriNo(string procuderName, string inventorySeriNo) { throw new NotImplementedException(); }
        public List<Inventory> GetAll()
        {
            throw new NotImplementedException();
        }
        public string UpdateNew(Inventory entity)
        {
            throw new NotImplementedException();
        }






        public Inventory Get(Guid id)
        {
            throw new NotImplementedException();
        }
        public string Update(Inventory entity, string oldName)
        {
            throw new NotImplementedException();
        }

    }
}
