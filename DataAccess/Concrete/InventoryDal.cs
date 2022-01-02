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
    public class InventoryDal : SqlService, IRepository<Inventory>
    {
        static InventoryDal inventoryDal;
        SqlService sqlService;
        Inventory inventory;
        public InventoryDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }

        public string Add(Inventory entity)
        {
            string result = null;
            try
            {
                var (isSucces, msg) = sqlService.StoredV2("InventoryAdd",
                   new SqlParameter("@inventoryserino", entity.InventorySeriNo),
                   new SqlParameter("@inventoryname", entity.InventoryName),
                   new SqlParameter("@amount", entity.Amount),
                   new SqlParameter("@info", entity.Info),
                   new SqlParameter("@createdtime", entity.CreatedTime),
                   new SqlParameter("@createdemployee", entity.CreatedEmployee));

                return "Envanter Başarı İle Eklendi";

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
                var (isSuccess, msg) = sqlService.StoreReaderV2("InventoryDelete", new SqlParameter("@inventoryid", id));

                if (isSuccess)
                {
                    result = "Envanter  Başarı İle Silindi";
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
        public List<Inventory> GetInventoryByCreatedDate(string procuderName, DateTime date)
        {
            List<Inventory> inventoryList = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@createdtime", date));
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    inventoryList = new List<Inventory>();
                    foreach
                         (DataRow dataRow in dt.Rows)
                    {
                        inventoryList.Add(new Inventory(
                          Guid.Parse(dataRow["INVENTORYID"].ToString()),
                          dataRow["INVENTORYSERINO"].ToString(),
                           dataRow["INVENTORYNAME"].ToString(),
                           dataRow["AMOUNT"].ContInt(),
                           dataRow["INFO"].ToString(),
                           dataRow["CREATEDTIME"].ConDate(),
                           dataRow["TC"].ToString(),
                           $"{dataRow["NAME"].ToString()} {dataRow["SURNAME"].ToString()}")
                           );
                    }
                }
            }
            catch (Exception)
            {


            }
            finally { }
            return inventoryList;
        }
        public List<Inventory> GetInventoryByCreatedEmployee(string procuderName, string employeeName)
        {
            List<Inventory> inventoryList = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@createdemployee", employeeName));
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    inventoryList = new List<Inventory>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        inventoryList.Add(new Inventory(
                           Guid.Parse(dataRow["INVENTORYID"].ToString()),
                           dataRow["INVENTORYSERINO"].ToString(),
                            dataRow["INVENTORYNAME"].ToString(),
                            dataRow["AMOUNT"].ContInt(),
                            dataRow["INFO"].ToString(),
                            dataRow["CREATEDTIME"].ConDate(),
                            dataRow["TC"].ToString(),
                            $"{dataRow["NAME"].ToString()} {dataRow["SURNAME"].ToString()}")
                            );
                    }
                }
            }
            catch (Exception)
            {


            }
            finally { }
            return inventoryList;

        }
        public List<Inventory> GetInventoryByName(string procuderName, string inventoryName)
        {
            List<Inventory> inventories = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@inventoryname", inventoryName));
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    inventories = new List<Inventory>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        inventories.Add(new Inventory
                            (Guid.Parse(dataRow["INVENTORYID"].ToString()),
                            dataRow["INVENTORYSERINO"].ToString(),
                            dataRow["INVENTORYNAME"].ToString(),
                            dataRow["AMOUNT"].ContInt(),
                            dataRow["INFO"].ToString(),
                            dataRow["CREATEDTIME"].ConDate(),
                            dataRow["TC"].ToString(),
                           $"{dataRow["NAME"].ToString()} {dataRow["SURNAME"].ToString()}"));
                    }
                }
                else inventories = null;


            }
            catch (Exception)
            {

            }
            finally { }
            return inventories;

        }
        public List<Inventory> GetInventoryBySeriNo(string procuderName, string inventorySeriNo)
        {
            List<Inventory> inventories = null;
            try
            {
                var (dt, msg) = sqlService.StoredV2(procuderName, new SqlParameter("@inventoryserino", inventorySeriNo));
                if (msg != null)
                {
                    return null;
                }
                if (dt.Rows.Count > 0)
                {
                    inventories = new List<Inventory>();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        inventories.Add(new Inventory
                            (Guid.Parse(dataRow["INVENTORYID"].ToString()),
                            dataRow["INVENTORYSERINO"].ToString(),
                            dataRow["INVENTORYNAME"].ToString(),
                            dataRow["AMOUNT"].ContInt(),
                            dataRow["INFO"].ToString(),
                            dataRow["CREATEDTIME"].ConDate(),
                            dataRow["TC"].ToString(),
                           $"{dataRow["NAME"].ToString()} {dataRow["SURNAME"].ToString()}"));
                    }
                }
                else inventories = null;


            }
            catch (Exception)
            {

            }
            finally { }
            return inventories;

        
    }
    public List<Inventory> GetAll()
    {
        List<Inventory> inventoryList = null;

        try
        {
            var (dt, msg) = sqlService.StoredV2("InventoryList");
            if (msg != null)
            {
                return null;
            }

            if (dt.Rows.Count > 0)
            {
                inventoryList = new List<Inventory>();

                foreach (DataRow dataRow in dt.Rows)
                {

                    inventoryList.Add(new Inventory(
                       Guid.Parse(dataRow["INVENTORYID"].ToString()),
                       dataRow["INVENTORYSERINO"].ToString(),
                        dataRow["INVENTORYNAME"].ToString(),
                        dataRow["AMOUNT"].ContInt(),
                        dataRow["INFO"].ToString(),
                        dataRow["CREATEDTIME"].ConDate(),
                        dataRow["TC"].ToString(),
                        $"{dataRow["NAME"].ToString()} {dataRow["SURNAME"].ToString()}")
                        );
                }
            }

        }
        catch (Exception ex) { }
        finally { }

        return inventoryList;
    }
    public string UpdateNew(Inventory entity)
    {
        string result = null;
        try
        {
            var (isSuccess, msg) = sqlService.StoreReaderV2("InventoryUpdate", new SqlParameter("@inventoryid", entity.InventoryId),
                new SqlParameter("@inventoryserino", entity.InventorySeriNo), new SqlParameter("@inverntoryname", entity.InventoryName),
                new SqlParameter("@amount", entity.Amount), new SqlParameter("@info", entity.Info),
                new SqlParameter("@createdtime", entity.CreatedTime)
                , new SqlParameter("@createdemployee", entity.CreatedEmployee));
            if (isSuccess)
            {
                result = "Envanter  Başarı İle Güncellendi";
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



    public string Update(Inventory entity, string oldName)
    {
        throw new NotImplementedException();
    }
    public Inventory Get(Guid id)
    {
        throw new NotImplementedException();
    }

    public static InventoryDal GetInstance()
    {
        if (inventoryDal == null)
        {
            inventoryDal = new InventoryDal();
        }
        return inventoryDal;
    }

}
}
