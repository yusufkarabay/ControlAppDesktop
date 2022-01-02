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
       // string controlText;
        public InventoryManager()
        {
            inventorydal = InventoryDal.GetInstance();
        }
        //string IsInventoryComplete(Inventory inventory)
        //{
        //    if (string.IsNullOrEmpty(inventory.InventorySeriNo))
        //    {
        //        return "Lütfen Bir İş Giriniz. Boş Kayıt Girilemez";
        //    }
        //    return "";
        //}
        public string Add(Inventory entity)
        {
            try
            {
                //    controlText = IsInventoryComplete(entity);
                //    if (controlText != "")
                //    {
                //        return controlText;
                //    }
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
        public List<Inventory> GetInventoryByCreatedDate(string procuderName, DateTime date)
        {
            try
            {
                if (date == null)
                {
                    return null;
                }
                return inventorydal.GetInventoryByCreatedDate(procuderName, date);

            }
            catch (Exception)
            {

                return new List<Inventory>();
            }
        }
        public List<Inventory> GetInventoryByCreatedEmployee(string procuderName, string employeeName)
        {
            try
            {
                if (employeeName == null)
                {
                    return null;
                }
                return inventorydal.GetInventoryByCreatedEmployee(procuderName, employeeName);

            }
            catch (Exception)
            {

                return new List<Inventory>();
            }
        }
        public List<Inventory> GetInventoryByName(string procuderName, string inventoryName)
        {

            try
            {
                if (inventoryName == null)
                {
                    return null;
                }
                return inventorydal.GetInventoryByName(procuderName, inventoryName);

            }
            catch (Exception)
            {

                return new List<Inventory>();
            }
        }
        public List<Inventory> GetInventoryBySeriNo(string procuderName, string inventorySeriNo)
        {
            try
            {
                if (inventorySeriNo == null)
                {
                    return null;
                }
                return inventorydal.GetInventoryBySeriNo(procuderName, inventorySeriNo);

            }
            catch (Exception)
            {

                return new List<Inventory>();
            }
        }
        public List<Inventory> GetAll()
        {
            try
            {
                return inventorydal.GetAll();
            }
            catch
            {
                return new List<Inventory>();
            }
        }
        public string UpdateNew(Inventory entity)
        {
            try
            {
                if (entity.InventoryName == null)
                {
                    return " Güncellemek İstediğiniz Envanteri Seçiniz";

                }
                //controlText = IsInventoryComplete(entity);
                //if (controlText != "")
                //{
                //    return controlText;
                //}
                return inventorydal.UpdateNew(entity);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }





        public static InventoryManager GetInstance()
        {
            if (inventoryManager == null)
            {
                inventoryManager = new InventoryManager();
            }
            return inventoryManager;
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
