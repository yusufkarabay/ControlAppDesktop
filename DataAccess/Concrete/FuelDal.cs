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
    public class FuelDal : SqlService, IRepository<Fuel>
    {
        static FuelDal fuelDal;
        SqlService sqlService;
        public FuelDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }
        public static FuelDal GetInstance()
        {
            if (fuelDal == null)
            {
                fuelDal = new FuelDal();
            }
            return fuelDal;
        }
        public string Add(Fuel entity)
        {
            string result = null;
            try
            {
                var (isSuccess, msg) = sqlService.StoreReaderV2("FuelAdd", new SqlParameter("@fueltime", entity.FuelTime),
                    new SqlParameter("@fuelemployee", entity.FuelEmployee));

                if (isSuccess)
                {
                    return "Jeneratör' Yakıt Alındı";
                }

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            
            return result;
        }

        public string GetLastTime()
        {
            string fuelTime;
            

            try
            {
                fuelTime =sqlService.ReaderString("FuelLastTime");
               
               
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return fuelTime;
        }
        public string GetLastEmployee()
        {
            string fuelEmployee;


            try
            {
                fuelEmployee = sqlService.ReaderString("FuelLastEmployee");


            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return fuelEmployee;
        }

        public string LastFuel()
        {
            string lastFuel;
            try
            {
                lastFuel = sqlService.Reader("FeulLast");


            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return lastFuel;
        }

        public string Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Fuel Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Fuel> GetAll()
        {
            throw new NotImplementedException();
        }

        public string Update(Fuel entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public string UpdateNew(Fuel entity)
        {
            throw new NotImplementedException();
        }
    }
}
